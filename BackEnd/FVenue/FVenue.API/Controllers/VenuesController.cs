using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Venue;
using DTOs.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FVenue.API.Controllers
{
    public class VenuesController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IWardService _wardService;
        private readonly IAccountService _accountService;

        public VenuesController(
            DatabaseContext context,
            IMapper mapper,
            IWardService wardService,
            IAccountService accountService)
        {
            _context = context;
            _mapper = mapper;
            _wardService = wardService;
            _accountService = accountService;
        }

        #region View

        public IActionResult Index() => View();

        [HttpGet, Route("Venues/InsertVenuePopup")]
        public async Task<PartialViewResult> InsertVenuePopup()
        {
            var wards = await _wardService.GetListWards();
            var selectListWards = new SelectList(wards, "Id", "Name");

            var accounts = await _accountService.GetListAccounts();
            var selectListAccounts = new SelectList(accounts, "Id", "FullName");

            ViewBag.ListWards = selectListWards;
            ViewBag.ListAccounts = selectListAccounts;
            return PartialView("_VenuePartial");
        }

        #endregion

        #region Data

        [HttpGet, Route("Venues/GetVenueDTOs")]
        public List<VenueDTO> GetVenueDTOs()
            => _mapper.Map<List<Venue>, List<VenueDTO>>(_context.Venues.OrderByDescending(x => x.Id).ToList());

        [HttpGet, Route("Venues/GetVenueDescription/{id}")]
        public string GetVenueDescription(int id)
            => _context.Venues.Find(id).Description ?? "Chưa có mô tả về địa điểm này";

        [HttpPost, Route("Venues/InsertVenue")]
        public IActionResult InsertVenue([FromForm] VenueInsertDTO venueInsertDTO)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var venue = _mapper.Map<VenueInsertDTO, Venue>(venueInsertDTO);
                    if (venueInsertDTO.Image != null)
                    {
                        // Upload Image Process + Insert Venue
                        var imageValidation = ValidationService.ImageValidation(venueInsertDTO.Image);
                        if (!imageValidation.Key)
                            throw new Exception(imageValidation.Value);
                        var imagePath = _imageService.GetImagePath(venueInsertDTO.Image);
                        venue.Image = imagePath;
                        venue.LowerPrice = 0;
                        venue.UpperPrice = 0;
                        venue.Status = true;
                        _context.Venues.Add(venue);
                        _context.SaveChanges();
                        var uploadImage = _imageService.UploadImage(venueInsertDTO.Image);
                        if (uploadImage.Code != 200)
                            throw new Exception("Tệp tải lên thất bại");
                        //return "Thêm địa điểm thành công";
                    }
                    else
                    {
                        venue.LowerPrice = 0;
                        venue.UpperPrice = 0;
                        venue.Status = true;
                        _context.Venues.Add(venue);
                        _context.SaveChanges();
                    }
                    transaction.Commit();
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
                    _context.Venues.Update(new Venue
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
                    _context.SaveChanges();
                    transaction.Commit();
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
