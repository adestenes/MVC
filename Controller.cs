// Controllers/TravelController.cs
using System.Web.Mvc;
using YourNamespace.Models;

namespace YourNamespace.Controllers
{
    public class TravelController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TravelModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.AverageSpeed = model.CalculateAverageSpeed();
            }
            return View(model);
        }
    }
}
