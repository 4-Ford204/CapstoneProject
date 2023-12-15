using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Venue;
using Microsoft.AspNetCore.Mvc;

namespace FVenue.API.Controllers
{
    public class VenuesController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public VenuesController(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        #region View

        public IActionResult Index()
        {
            return View();
        }

        #endregion

        #region Data

        [HttpGet, Route("Venues/GetVenueDTOs")]
        public List<VenueDTO> GetVenueDTOs()
            => _mapper.Map<List<Venue>, List<VenueDTO>>(_context.Venues.ToList());

        #endregion
    }
}
