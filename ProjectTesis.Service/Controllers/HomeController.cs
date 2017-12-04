using System.Web.Mvc;

namespace ProjectTesis.Service.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Orbitum Web Api";

            return View();
        }
    }
}
