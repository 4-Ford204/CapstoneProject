using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Account;
using DTOs.Models.Venue;
using Microsoft.AspNetCore.Mvc;

namespace FVenue.API.Controllers
{
    public class AccountsController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public AccountsController(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        #region View

        public IActionResult Index() => View();

        #endregion

        #region Data

        [HttpGet, Route("Accounts/GetAccountDTOs")]
        public List<AccountDTO> GetVenueDTOs()
            => _mapper.Map<List<Account>, List<AccountDTO>>(_context.Accounts.ToList());

        #endregion
    }
}
