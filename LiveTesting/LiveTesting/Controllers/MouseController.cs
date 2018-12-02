using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiveTesting.Controllers
{
    public class MouseController : Controller
    {
        // GET: Mouse
        public ActionResult Index(int? id)
        {
            return View(id);
        }

        [HttpGet]
        public  ActionResult About()
        {
            return View();
        }
    }
}