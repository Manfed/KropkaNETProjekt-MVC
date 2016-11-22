using QuizwanieMVCv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizwanieMVCv2.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            if (MvcApplication.userStatus.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                QuizwanieService.QuizwanieServiceClient service = new QuizwanieService.QuizwanieServiceClient();
                var result = service.ValidateUser(model.Login, service.hashSha512(model.Password));
                if (result != null)
                {
                    MvcApplication.userStatus.IsAuthenticated = true;
                    MvcApplication.userStatus.UserId = result.Id;
                    MvcApplication.userStatus.Role = result.Role;
                    MvcApplication.userStatus.UserName = model.Login;
                    MvcApplication.userStatus.PasswordHash = service.hashSha512(model.Password);
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Błędny login lub hasło");
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                QuizwanieService.QuizwanieServiceClient service = new QuizwanieService.QuizwanieServiceClient();
                var result = service.CreateUser(model.Login, service.hashSha512(model.Password));
                if (result != null)
                {
                    MvcApplication.userStatus.IsAuthenticated = true;
                    MvcApplication.userStatus.UserId = result.Id;
                    MvcApplication.userStatus.Role = result.Role;
                    MvcApplication.userStatus.UserName = model.Login;
                    MvcApplication.userStatus.PasswordHash = service.hashSha512(model.Password);
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Użytkownik o podanej nazwie już istnieje");
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult Logout()
        {
            MvcApplication.userStatus = new UserSignInModel(false);
            return RedirectToAction("Index", "Login");
        }
    }
}