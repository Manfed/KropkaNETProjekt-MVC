using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizwanieMVCv2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (MvcApplication.userStatus.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult About()
        {
            if (MvcApplication.userStatus.IsAuthenticated)
            {
                ViewBag.Message = "Projekt z przedmiotu SERWISY INTERNETOWE .NET - Serwis ASP.NET";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}