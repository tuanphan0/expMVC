using BaiTestCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTestCS.Controllers
{
    public class HomeControllerController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            var Mess = new HomeModels();
            Mess.NewModels = "HelloWorld Models";
            ViewBag.WelcomeString = "HelloWorld ViewBag";
            return View(Mess);
        }
    }
}