﻿using BusinessObjects;
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
            var administratorName = Request.Cookies["AdministratorName"];
            if (!String.IsNullOrEmpty(administratorName))
            {
                HttpContext.Session.SetString("AdministratorName", administratorName);
                return RedirectToAction("Index");
            }
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
                        CookieOptions options = new CookieOptions
                        {
                            // Domain: Specifies the domain associated with the cookie.
                            // Expiration time: Determines the cookie's expiration time.
                            // Path: Defines the path for which the cookie is valid.
                            // Security policy: Specifies if the cookie should be accessible only over HTTPS.
                            // HttpOnly: Indicates if the cookie is available only to the server.
                            //Domain = HttpContext.Request.Host.Value,
                            Expires = DateTime.Now.AddDays(7),
                            //Path = "/",
                            //Secure = true,
                            //HttpOnly = true
                        };
                        var administratorName = account.FullName;
                        Response.Cookies.Append("AdministratorName", administratorName, options);
                        HttpContext.Session.SetString("AdministratorName", administratorName);
                        return View("Index");
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
            Response.Cookies.Delete("AdministratorName");
            HttpContext.Session.Remove("AdministratorName");
            return RedirectToAction("LoginPage");
        }
    }
}