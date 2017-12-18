using System.Web.Mvc;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Administración de usuarios.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página de contacto";

            return View();
        }
    }
}
