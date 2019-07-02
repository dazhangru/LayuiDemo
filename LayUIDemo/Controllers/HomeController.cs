using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayUIDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //11111
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";
            //22222
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}