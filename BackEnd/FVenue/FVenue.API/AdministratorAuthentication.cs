using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FVenue.API
{
    public class AdministratorAuthentication : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session.GetString("AdministratorName") == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary {
                        { "Controller", "Home" },
                        { "Action", "AuthenticationMiddleware" }
                    });
            }
        }
    }
}
