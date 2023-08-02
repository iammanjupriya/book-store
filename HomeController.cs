using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult First()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Books()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Privacy()
        {
            return View();


        }
        public ActionResult NEWARRIVAL()
        {
            return View();


        }
        public ActionResult TRENDINGNOW()
        {
            return View();


        }
    }
}