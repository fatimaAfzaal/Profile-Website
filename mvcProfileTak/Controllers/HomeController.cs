using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcProfileTak.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "I am Fatima Afzaal,currently doing my bachlor's degree in computer science from Air University Aerospace and Aviation Campus Kamra. I am interested in data science. Also have a knowledge of android and asp.net development ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "My contact Info";

            return View();
        }
    }
}