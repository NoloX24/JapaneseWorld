using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JapaneseLearningApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Japanese World: A web application for learning the Japanese language";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Let me know how I am doing!";

            return View();
        }
    }
}