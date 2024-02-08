using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs;
using DTOs.Models.Venue;
using DTOs.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FVenue.API.Controllers
{
    [AdministratorAuthentication]
    public class VenuesController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IAccountService _accountService;
        private readonly IImageService _imageService;
        private readonly ILocationService _locationService;
        private readonly IVenueService _venueService;

        public VenuesController(
            DatabaseContext context,
            IMapper mapper,
            IAccountService accountService,
            IImageService imageService,
            ILocationService locationService,
            IVenueService venueService)
        {
            _context = context;
            _mapper = mapper;
            _accountService = accountService;
            _imageService = imageService;
            _locationService = locationService;
            _venueService = venueService;
        }

        #region View

        public IActionResult Index() => View();

        [HttpGet, Route("Venues/InsertVenuePopup")]
        public PartialViewResult InsertVenuePopup()
            => PartialView("_VenueInsertPartial");

        [HttpGet, Route("Venues/UpdateVenuePopup/{id}")]
        public PartialViewResult UpdateVenuePopup(int id)
        {
            var venue = _context.Venues.FirstOrDefault(x => x.Id == id);
            var venueUpdateDTO = new VenueUpdateDTO()
            {
                Id = venue.Id,
                Name = venue.Name,
                Image = venue.Image,
                Description = venue.Description,
                Street = venue.Street,
                WardId = venue.WardId,
                GeoLocation = venue.GeoLocation,
                OpenTime = Common.ConvertDateTimeToTimeOnly(venue.OpenTime).ToString("HH:mm"),
                CloseTime = Common.ConvertDateTimeToTimeOnly(venue.CloseTime).ToString("HH:mm"),
                LowerPrice = venue.LowerPrice,
                UpperPrice = venue.UpperPrice,
                Status = venue.Status,
                AccountId = venue.AccountId
            };
            return PartialView("_VenueUpdatePartial", venueUpdateDTO);
        }

        #endregion

        #region Data

        [HttpGet, Route("Venues/GetVenueDTOs")]
        public List<VenueDTO> GetVenueDTOs()
            => _mapper.Map<List<Venue>, List<VenueDTO>>(_context.Venues.OrderByDescending(x => x.Id).ToList());

        [HttpPost, Route("Venues/InsertVenue")]
        public IActionResult InsertVenue([FromForm] VenueInsertDTO venueInsertDTO)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var venue = _mapper.Map<VenueInsertDTO, Venue>(venueInsertDTO);
                    // Upload Image Process + Insert Venue
                    var imageValidation = ValidationService.ImageValidation(venueInsertDTO.Image);
                    if (!imageValidation.Key)
                        throw new Exception(imageValidation.Value);
                    var imagePath = _imageService.GetImagePath(venueInsertDTO.Image);
                    venue.Image = imagePath;
                    venue.LowerPrice = 0;
                    venue.UpperPrice = 0;
                    venue.Status = true;
                    _venueService.InsertVenue(venue);
                    var uploadImage = _imageService.UploadImage(venueInsertDTO.Image, imagePath);
                    if (!uploadImage)
                        throw new Exception("Tệp tải lên thất bại");
                    //return "Thêm địa điểm thành công";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    transaction.Rollback();
                    //return $"{ex.Message}";
                }
            }
            return View("Index");
        }

        /// <summary>
        /// Update Public Venue
        /// </summary>
        /// <param name="venueUpdateDTO"></param>
        /// <returns></returns>
        [HttpPost, Route("Venues/UpdateVenue")]
        public IActionResult UpdateVenue([FromForm] VenueUpdateDTO venueUpdateDTO)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var venue = _venueService.GetVenue(venueUpdateDTO.Id);
                    _venueService.UpdateVenue(new Venue
                    {
                        Id = venueUpdateDTO.Id,
                        Name = venueUpdateDTO.Name,
                        //Image = venueUpdateDTO.ImageFile != null ? _imageService.GetImagePath(venueUpdateDTO.ImageFile) : venue.Image,
                        //Description = venueUpdateDTO.Description,
                        Street = venueUpdateDTO.Street,
                        WardId = venueUpdateDTO.WardId,
                        GeoLocation = venueUpdateDTO.GeoLocation,
                        OpenTime = Common.ConvertTimeOnlyToDateTime(venueUpdateDTO.OpenTime),
                        CloseTime = Common.ConvertTimeOnlyToDateTime(venueUpdateDTO.CloseTime),
                        LowerPrice = venue.LowerPrice,
                        UpperPrice = venue.UpperPrice,
                        Status = venue.Status,
                        AccountId = venueUpdateDTO.AccountId
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    transaction.Rollback();
                }
            }
            return View("Index");
        }

        [HttpPut, Route("Venues/ChangeVenueStatus")]
        public string ChangeVenueStatus(int[] ids)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    foreach (var id in ids)
                    {
                        var venue = _context.Venues.FirstOrDefault(x => x.Id == id);
                        if (venue == null)
                            throw new Exception($"{id} không tồn tại");
                        venue.Status = !venue.Status;
                        _context.Entry(venue).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        if (_context.SaveChanges() != 1)
                            throw new Exception("Save Changes Error");
                    }
                    transaction.Commit();
                    return $"Đã đổi trạng thái của các địa điểm [{String.Join(",", ids)}]";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return ex.Message;
                }
            }
        }

        #endregion
    }
}
