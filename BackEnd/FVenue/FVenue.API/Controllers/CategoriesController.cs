using Microsoft.AspNetCore.Mvc;

namespace FVenue.API.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index() => View();
    }
}
