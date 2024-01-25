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
            => _mapper.Map<List<Venue>, List<VenueDTO>>(_context.Venues.ToList());

        #endregion
    }
}
