using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PRG522_SA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
           return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        [Authorize]
        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }
    }
}