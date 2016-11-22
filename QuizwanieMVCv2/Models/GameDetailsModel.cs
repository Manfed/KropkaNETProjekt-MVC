using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizwanieMVCv2.Models
{
    public class GameDetailsModel
    {
        public QuizwanieService.OngoingGame Game { get; set; }
        public string CallerUserName { get; set; }
        public string OpponentName { get; set; }

        public GameDetailsModel(QuizwanieService.OngoingGame game)
        {
            QuizwanieService.QuizwanieServiceClient service = new QuizwanieService.QuizwanieServiceClient();
            this.Game = game;
            var callerUser = service.GetUser(Game.UserId);
            var opponentUser = service.GetUser(Game.OpponentUserId);

            this.CallerUserName = callerUser.Name;
            this.OpponentName = opponentUser.Name;
        }
    }
}