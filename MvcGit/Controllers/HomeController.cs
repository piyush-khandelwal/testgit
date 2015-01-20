using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcGit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //this is index action
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            //this is about action
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            // this is contact action
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
