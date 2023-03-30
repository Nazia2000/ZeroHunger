using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zerohunger.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        [HttpGet]
        public ActionResult Login()
        {
           
            return View();
        }


        [HttpPost]
        public ActionResult Logout() 
        {
            return View();
        }

    }
}