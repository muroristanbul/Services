using System;
using System.Web.Mvc;
using Services.Logging.Web.Models;

namespace Services.Logging.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new IndexViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(IndexViewModel model)
        {
            model.Token = Guid.NewGuid().ToString();
            return View(model);
        }
    }
}