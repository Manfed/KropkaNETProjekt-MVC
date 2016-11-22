using QuizwanieMVCv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizwanieMVCv2.Controllers
{
    public class QuestionsController : Controller
    {
        // GET: Questions
        public ActionResult Create()
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

        [HttpPost]
        public ActionResult Create(QuestionModel model)
        {
            if (ModelState.IsValid)
            {
                QuizwanieService.QuizwanieServiceClient service = new QuizwanieService.QuizwanieServiceClient();
                service.AddQuestion(MvcApplication.userStatus.UserName, MvcApplication.userStatus.PasswordHash,
                    model.Content, model.CorrectAnswer, model.WrongAnswer1, model.WrongAnswer2, model.WrongAnswer3);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Formularz zawiera błędne dane.");
            return View(model);
        }

        public ActionResult Authorize()
        {
            if (MvcApplication.userStatus.IsAuthenticated)
            {
                if (MvcApplication.userStatus.Role.Equals("Admin"))
                {
                    QuizwanieService.QuizwanieServiceClient service = new QuizwanieService.QuizwanieServiceClient();
                    var questions = service.GetUnauthorizedQuestions(MvcApplication.userStatus.UserName, MvcApplication.userStatus.PasswordHash);

                    return View(questions);
                }
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult Apply(int id)
        {
            QuizwanieService.QuizwanieServiceClient service = new QuizwanieService.QuizwanieServiceClient();

            service.AuthorizeQuestion(MvcApplication.userStatus.UserName, MvcApplication.userStatus.PasswordHash, id);
            return RedirectToAction("Authorize");
        }

        public ActionResult Delete(int id)
        {
            QuizwanieService.QuizwanieServiceClient service = new QuizwanieService.QuizwanieServiceClient();

            service.DeleteUnauthorizeQuestion(MvcApplication.userStatus.UserName, MvcApplication.userStatus.PasswordHash, id);
            return RedirectToAction("Authorize");
        }
    }
}