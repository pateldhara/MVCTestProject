using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcExampleApplication.Models;

namespace MvcExampleApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            ViewBag.Message = "Welcome to ASP.NET MVC!";       
            return View();
        }


        public ActionResult DisplayFooter()
        {
            var Model = new HomeData
            {
                FooterText = "This is not for copy",
                CompanyName = "LBI"
            };
            return PartialView("_HomeData", Model);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
