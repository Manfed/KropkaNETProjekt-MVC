using QuizwanieMVCv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizwanieMVCv2.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Games()
        {
            if(MvcApplication.userStatus.IsAuthenticated && !MvcApplication.userStatus.Role.Equals("Admin"))
            {
                QuizwanieService.QuizwanieServiceClient service = new QuizwanieService.QuizwanieServiceClient();
                var userGames = service.GetUserGames(MvcApplication.userStatus.UserName, MvcApplication.userStatus.PasswordHash,
                    MvcApplication.userStatus.UserId);

                List<GameDetailsModel> gameModel = new List<GameDetailsModel>();
                foreach (QuizwanieService.OngoingGame game in userGames)
                {
                    gameModel.Add(new GameDetailsModel(game));
                }
                return View(gameModel);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }

        public ActionResult Play(int gameId)
        {
            if (MvcApplication.userStatus.IsAuthenticated && !MvcApplication.userStatus.Role.Equals("Admin"))
            {
                QuizwanieService.QuizwanieServiceClient service = new QuizwanieService.QuizwanieServiceClient();
                var question = service.GetNextQuestion(gameId, MvcApplication.userStatus.UserId);

                return View(new ShuffledQuestion(question, gameId));
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Check(Answer answer)
        {
            QuizwanieService.QuizwanieServiceClient service = new QuizwanieService.QuizwanieServiceClient();
            service.CheckAnswer(answer.GameId, answer.QuestionId, MvcApplication.userStatus.UserId, answer.ChosenAnswer);

            return RedirectToAction("Play", new { gameId = answer.GameId });
        }

        public ActionResult NewGame()
        {
            if (MvcApplication.userStatus.IsAuthenticated && !MvcApplication.userStatus.Role.Equals("Admin"))
            {
                QuizwanieService.QuizwanieServiceClient service = new QuizwanieService.QuizwanieServiceClient();
                service.startLookingForGame(MvcApplication.userStatus.UserId);

                return RedirectToAction("Games", "Game");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}