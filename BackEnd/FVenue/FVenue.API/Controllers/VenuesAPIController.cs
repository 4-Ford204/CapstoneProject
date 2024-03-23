using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Venue;
using DTOs.Repositories.Interfaces;
using FVenue.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace FVenue.API.Controllers
{
    [Route("API/[controller]")]
    [ApiController]
    public class VenuesAPIController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IImageService _imageService;
        private readonly IVenueService _venueService;

        public VenuesAPIController(IMapper mapper, IImageService imageService, IVenueService venueService)
        {
            _mapper = mapper;
            _imageService = imageService;
            _venueService = venueService;
        }

        [HttpGet, Route("GetVenueDTOs/{pageIndex}/{pageSize}")]
        public ActionResult<JsonModel> GetVenueDTOs(int pageIndex, int pageSize)
        {
            try
            {
                var venues = _venueService.GetVenues();
                var venueDTOs = _mapper.Map<List<Venue>, List<VenueDTO>>(venues);
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.OK,
                    Message = $"{venues.Count} venues",
                    Data = new PaginationModel<VenueDTO>(venueDTOs, pageIndex, pageSize)
                };
            }
            catch (Exception ex)
            {
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.InternalServerError,
                    Message = $"{ex.Message}"
                };
            }
        }

        [HttpGet, Route("GetVenueDTO/{id}")]
        public ActionResult<JsonModel> GetVenueDTO(int id)
        {
            try
            {
                var venue = _venueService.GetVenue(id);
                var venueDTO = _mapper.Map<Venue, VenueDTO>(venue);
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.OK,
                    Message = $"Venue {venueDTO.Name}",
                    Data = venueDTO
                };
            }
            catch (Exception ex)
            {
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.InternalServerError,
                    Message = $"{ex.Message}"
                };
            }
        }

        /// <summary>
        /// Author: PhucHV
        /// </summary>
        /// <returns>Danh sách những địa điểm miễn phí</returns>
        [HttpGet, Route("GetPublicVenueDTOs/{pageIndex}/{pageSize}")]
        public ActionResult<JsonModel> GetPublicVenueDTOs(int pageIndex, int pageSize)
        {
            try
            {
                var publicVenues = _venueService.GetVenuesBySubCategory(1)
                    .Where(x => x.LowerPrice == 0 && x.UpperPrice == 0 && x.Status)
                    .OrderBy(x => x.Name).ToList();
                var publicVenueDTOs = _mapper.Map<List<Venue>, List<VenueDTO>>(publicVenues);
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.OK,
                    Message = $"{publicVenues.Count} public venues",
                    Data = new PaginationModel<VenueDTO>(publicVenueDTOs, pageIndex, pageSize)
                };
            }
            catch (Exception ex)
            {
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.InternalServerError,
                    Message = $"{ex.Message}"
                };
            }
        }

        /// <summary>
        /// Author: PhucHV
        /// </summary>
        /// <returns>Danh sách những địa điểm trả phí</returns>
        [HttpGet, Route("GetNonPublicVenueDTOs/{pageIndex}/{pageSize}")]
        public ActionResult<JsonModel> GetNonPublicVenueDTOs(int pageIndex, int pageSize)
        {
            try
            {
                using (var _context = new DatabaseContext())
                {
                    List<Venue> nonPublicVenues = new List<Venue>();
                    var venueSubCategories = _context.VenueSubCategories.Where(x => x.SubCategoryId != 1);
                    foreach (var venueSubCategory in venueSubCategories)
                        nonPublicVenues.Add(_venueService.GetVenue(venueSubCategory.VenueId));
                    var nonPublicVenueDTOs = _mapper.Map<List<Venue>, List<VenueDTO>>(nonPublicVenues.Where(x => x.Status).ToList());
                    return new JsonModel
                    {
                        Code = EnumModel.ResultCode.OK,
                        Message = $"{nonPublicVenueDTOs.Count} non public venues",
                        Data = new PaginationModel<VenueDTO>(nonPublicVenueDTOs, pageIndex, pageSize)
                    };
                }
            }
            catch (Exception ex)
            {
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.InternalServerError,
                    Message = $"{ex.Message}"
                };
            }
        }

        [HttpGet, Route("SearchVenueBySubCategoryNameDTOs/{pageIndex}/{pageSize}")]
        public ActionResult<JsonModel> SearchVenueBySubCategoryNameDTOs(string subCategoryName, int pageIndex, int pageSize)
        {
            try
            {
                var resultVenue = _venueService.SearchVenueBySubCategoryName(subCategoryName);
                var venueDTOs = _mapper.Map<List<Venue>, List<VenueDTO>>(resultVenue);
                if (venueDTOs.Count == 0)
                {
                    return new JsonModel
                    {
                        Code = EnumModel.ResultCode.NotFound,
                        Message = $"No venues found for subcategory: {subCategoryName}"
                    };
                }
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.OK,
                    Message = $"{venueDTOs.Count} venues found for subcategory: {subCategoryName}",
                    Data = venueDTOs
                };
            }
            catch (Exception ex)
            {
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.InternalServerError,
                    Message = $"{ex.Message}"
                };
            }
        }

        [HttpPost, Route("InsertVenue")]
        public ActionResult<JsonModel> InsertVenue([FromForm] VenueInsertDTO venueInsertDTO)
        {
            if (!ModelState.IsValid)
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.BadRequest,
                    Message = $"Insert Venue Error",
                    Data = venueInsertDTO
                };
            if (String.IsNullOrEmpty(venueInsertDTO.ImageURL) && venueInsertDTO.Image != null)
            {
                var imageUploadResult = _imageService.UploadImage(venueInsertDTO.Image);
                if (imageUploadResult.Code == (int)EnumModel.ResultCode.OK)
                    venueInsertDTO.ImageURL = imageUploadResult.Data;
                else
                    return new JsonModel()
                    {
                        Code = EnumModel.ResultCode.InternalServerError,
                        Message = imageUploadResult.Message,
                        Data = venueInsertDTO
                    };
            }
            var venue = _mapper.Map<VenueInsertDTO, Venue>(venueInsertDTO);
            var result = _venueService.InsertVenue(venue);
            if (result.Key)
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.OK,
                    Message = $"Insert Venue Success",
                    Data = venueInsertDTO
                };
            else
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.InternalServerError,
                    Message = $"Insert Venue Error",
                    Data = result.Value
                };
        }

        [HttpPut, Route("UpdateVenue")]
        public ActionResult<JsonModel> UpdateVenue([FromBody] VenueUpdateDTO venueUpdateDTO)
        {
            if (!ModelState.IsValid)
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.BadRequest,
                    Message = $"Update Venue Error",
                    Data = venueUpdateDTO
                };
            var updateVenue = _mapper.Map<VenueUpdateDTO, Venue>(venueUpdateDTO);
            var result = _venueService.UpdateVenue(updateVenue);
            if (result.Key)
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.OK,
                    Message = $"Update Venue Success",
                    Data = venueUpdateDTO
                };
            else
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.InternalServerError,
                    Message = $"Update Venue Error",
                    Data = result.Value
                };
        }

        [HttpDelete, Route("DeleteVenue/{id}")]
        public ActionResult<JsonModel> DeleteVenue(int id)
        {
            var result = _venueService.DeleteVenue(id);
            if (result.Key)
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.OK,
                    Message = $"Delete Venue Success",
                    Data = id
                };
            else
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.InternalServerError,
                    Message = $"Delete Venue Error",
                    Data = result.Value
                };
        }
    }
}
