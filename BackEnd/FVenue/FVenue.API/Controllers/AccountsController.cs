using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Account;
using Microsoft.AspNetCore.Mvc;

namespace FVenue.API.Controllers
{
    [AdministratorAuthentication]
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
        public List<AccountDTO> GetAccountDTOs()
            => _mapper.Map<List<Account>, List<AccountDTO>>(_context.Accounts.ToList());

        [HttpGet, Route("Accounts/GetAdministratorDTOs")]
        public List<AccountDTO> GetAdministratorDTOs()
            => _mapper.Map<List<Account>, List<AccountDTO>>(_context.Accounts.Where(x => x.RoleId == (int)EnumModel.Role.Administrator).ToList());

        [HttpGet, Route("Accounts/GetLoginMethods")]
        public List<dynamic> GetLoginMethods()
        {
            List<dynamic> methods = new List<dynamic>();
            foreach (var method in Enum.GetValues(typeof(EnumModel.LoginMethod)))
                methods.Add(new { Id = (int)method, Name = method });
            return methods;
        }

        #endregion
    }
}
