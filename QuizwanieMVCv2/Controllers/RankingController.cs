using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizwanieMVCv2.Controllers
{
    public class RankingController : Controller
    {
        // GET: Ranking
        public ActionResult Index()
        {
            if (MvcApplication.userStatus.IsAuthenticated)
            {
                QuizwanieService.QuizwanieServiceClient service = new QuizwanieService.QuizwanieServiceClient();
                var users = service.getUsersRanking(MvcApplication.userStatus.UserName, MvcApplication.userStatus.PasswordHash);
                return View(users);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}