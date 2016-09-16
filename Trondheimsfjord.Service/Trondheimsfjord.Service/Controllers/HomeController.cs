using System.Web.Mvc;

namespace Trondheimsfjord.Service.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Trondheimsfjord";

            return View();
        }
    }
}
