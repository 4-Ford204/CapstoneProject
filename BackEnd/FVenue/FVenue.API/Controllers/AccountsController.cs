using Microsoft.AspNetCore.Mvc;

namespace FVenue.API.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Index() => View();
    }
}
