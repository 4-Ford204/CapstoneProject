using BusinessObjects;
using DTOs.Models.Account;
using DTOs.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FVenue.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAccountService _accountService;

        public HomeController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult AuthenticationMiddleware()
        {
            if (HttpContext.Session.GetString("UserName") != null)
                return RedirectToAction("Index");
            else
                return RedirectToAction("LoginPage");
        }

        public IActionResult LoginPage() => View();


        [AdministratorAuthentication]
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult AdministratorAuthentication([FromForm] AccountLoginDTO accountLoginDTO)
        {
            try
            {
                var account = _accountService.Login(accountLoginDTO, out string error);
                if (String.IsNullOrEmpty(error))
                {
                    if (account.RoleId != (int)EnumModel.Role.Administrator)
                        throw new Exception("Tài khoản của bạn không phải là quản trị viên");
                    else
                    {
                        HttpContext.Session.SetString("UserName", account.FullName);
                        return RedirectToAction("Index");
                    }
                }
                else
                    throw new Exception(error);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("LoginPage");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserName");
            return RedirectToAction("LoginPage");
        }
    }
}