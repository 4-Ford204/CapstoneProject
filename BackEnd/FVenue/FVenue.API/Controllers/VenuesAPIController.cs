using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models;
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

        public VenuesAPIController(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet, Route("Testing")]
        public string Testing() => "Testing JsonModel Ver 3";

        [HttpGet, Route("GetVenueDTOs/{pageIndex}/{pageSize}")]
        public async Task<ActionResult<JsonModel>> GetVenueDTOs(int pageIndex, int pageSize)
        {
            try
            {
                var venues = await _context.Venues.ToListAsync();
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
    }
}
