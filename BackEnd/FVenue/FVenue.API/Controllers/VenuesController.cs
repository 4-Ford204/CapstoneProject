using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs;
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
        private readonly IAccountService _accountService;
        private readonly IImageService _imageService;
        private readonly ILocationService _locationService;

        public VenuesController(
            DatabaseContext context,
            IMapper mapper,
            IAccountService accountService,
            IImageService imageService,
            ILocationService locationService)
        {
            _context = context;
            _mapper = mapper;
            _accountService = accountService;
            _imageService = imageService;
            _locationService = locationService;
        }

        #region View

        public IActionResult Index() => View();

        [HttpGet, Route("Venues/InsertVenuePopup")]
        public PartialViewResult InsertVenuePopup()
        {
            var wards = _locationService.GetWards();
            var selectWards = new SelectList(wards, "Id", "Name");

            var accounts = _accountService.GetAdministrators();
            var selectAccounts = new SelectList(accounts, "Id", "FullName");

            ViewBag.Wards = selectWards;
            ViewBag.Accounts = selectAccounts;
            return PartialView("_VenueInsertPartial");
        }

        #endregion

        #region Data

        [HttpGet, Route("Venues/GetVenueDTOs")]
        public List<VenueDTO> GetVenueDTOs()
            => _mapper.Map<List<Venue>, List<VenueDTO>>(_context.Venues.ToList());

        [HttpPost, Route("Venues/InsertVenue")]
        public string InsertVenue([FromForm] VenueInsertDTO venueInsertDTO)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var venue = _mapper.Map<VenueInsertDTO, Venue>(venueInsertDTO);
                    // Upload Image Process
                    var imageValidation = ValidationService.ImageValidation(venueInsertDTO.Image);
                    if (!imageValidation.Key)
                        throw new Exception(imageValidation.Value);
                    var imagePath = _imageService.GetImagePath(venueInsertDTO.Image);
                    venue.Image = imagePath;
                    //if (_context.SaveChanges() != 1)
                    //    throw new Exception("Save Changes Error");
                    var uploadImage = _imageService.UploadImage(venueInsertDTO.Image, imagePath);
                    if (!uploadImage)
                        throw new Exception("Tệp tải lên thất bại");
                    return "Thêm địa điểm thành công";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return $"{ex.Message}";
                }
            }
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
