using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Venue;
using DTOs.Repositories.Interfaces;
using FVenue.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FVenue.API.Controllers
{
    [Route("API/[controller]")]
    [ApiController]
    public class VenuesAPIController : ControllerBase
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IValidationService _validationService;

        public VenuesAPIController(DatabaseContext context, IMapper mapper, IValidationService validationService)
        {
            _context = context;
            _mapper = mapper;
            _validationService = validationService;
        }

        [HttpGet, Route("GetVenueDTOs/{pageIndex}/{pageSize}")]
        public async Task<ActionResult<JsonModel>> GetVenueDTOs(int pageIndex, int pageSize)
        {
            try
            {
                var venues = await _context.Venues.Where(x => x.Status == true).ToListAsync();
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
        public async Task<ActionResult<JsonModel>> InsertVenue([FromBody] VenueInsertDTO venueInsertDTO)
        {
            try
            {
                var venue = _mapper.Map<VenueInsertDTO, Venue>(venueInsertDTO);
                string result = String.Empty;
                if (!_validationService.VenueValidation(ModelState.IsValid, venue, out result))
                    return new JsonModel
                    {
                        Code = EnumModel.ResultCode.BadRequest,
                        Message = result,
                        Data = venueInsertDTO
                    };
                await _context.Venues.AddAsync(venue);
                if (await _context.SaveChangesAsync() < 1)
                    throw new Exception("Save Changes Async Error");
                else
                    return new JsonModel
                    {
                        Code = EnumModel.ResultCode.OK,
                        Message = "Insert Successfully",
                        Data = venueInsertDTO
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

        [HttpPut, Route("UpdateVenue")]
        public async Task<ActionResult<JsonModel>> UpdateVenue([FromBody] VenueUpdateDTO venueUpdateDTO)
        {
            try
            {
                var venue = await _context.Venues.FindAsync(venueUpdateDTO.Id);
                if (venue == null)
                    throw new Exception("Venue Not Found");
                var updateVenue = _mapper.Map<VenueUpdateDTO, Venue>(venueUpdateDTO);
                string result = String.Empty;
                if (!_validationService.VenueValidation(ModelState.IsValid, updateVenue, out result))
                    return new JsonModel
                    {
                        Code = EnumModel.ResultCode.BadRequest,
                        Message = result,
                        Data = updateVenue
                    };
                _context.Venues.Update(updateVenue);
                if (await _context.SaveChangesAsync() < 1)
                    throw new Exception("Save Changes Async Error");
                else
                    return new JsonModel
                    {
                        Code = EnumModel.ResultCode.OK,
                        Message = "Update Successfully",
                        Data = venueUpdateDTO
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

        [HttpDelete, Route("DeleteVenue/{id}")]
        public async Task<ActionResult<JsonModel>> DeleteVenue(int id)
        {
            try
            {
                var venue = await _context.Venues.FindAsync(id);
                if (venue == null)
                    throw new Exception("Venue Not Found");
                else
                {
                    venue.Status = false;
                    if (await _context.SaveChangesAsync() < 1)
                        throw new Exception("Save Changes Async Error");
                    else
                        return new JsonModel
                        {
                            Code = EnumModel.ResultCode.OK,
                            Message = "Delete Successfully",
                            Data = venue
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
    }
}
