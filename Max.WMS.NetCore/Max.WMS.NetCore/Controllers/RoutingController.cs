using Microsoft.AspNetCore.Mvc;

namespace Max.WMS.NetCore.Controllers
{
    public class RoutingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}