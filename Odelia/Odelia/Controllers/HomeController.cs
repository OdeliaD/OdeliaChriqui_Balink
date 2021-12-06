using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odelia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult WeatherNextDays()
        {
            return View();
        }
        
        public ActionResult WeatherByDay()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}