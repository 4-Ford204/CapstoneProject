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
        private readonly IVenueService _venueService;

        public VenuesAPIController(IMapper mapper, IVenueService venueService)
        {
            _mapper = mapper;
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

        [HttpPost, Route("InsertVenue")]
        public ActionResult<JsonModel> InsertVenue([FromBody] VenueInsertDTO venueInsertDTO)
        {
            if (!ModelState.IsValid)
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.BadRequest,
                    Message = $"Insert Venue Error",
                    Data = venueInsertDTO
                };
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
