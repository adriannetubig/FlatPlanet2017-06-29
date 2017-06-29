using FlatPlanetFunction;
using System.Web.Mvc;

namespace FlatPlanetWeb.Controllers
{
    public class HomeController : Controller
    {
        private IFCounter _iFCounter;
        public HomeController(IFCounter iFCounter)
        {
            _iFCounter = iFCounter;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create()
        {
            _iFCounter.Create();
            return Json(string.Empty);
        }

        [HttpPost]
        public JsonResult Count()
        {
            return Json(_iFCounter.Count());
        }
    }
}