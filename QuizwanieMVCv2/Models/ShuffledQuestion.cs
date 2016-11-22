using QuizwanieMVCv2.QuizwanieService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizwanieMVCv2.Models
{
    public class ShuffledQuestion
    {
        public List<string> Answers { get; set; }

        public string Content { get; set; }

        public string ChosenAnswer { get; set; }

        public int GameId { get; set; }

        public int QuestionId { get; set; }

        public ShuffledQuestion(Question question, int gameId)
        {
            if (question != null)
            {
                Answers = new List<string>();

                Answers.Add(question.CorrectAnswer);
                Answers.Add(question.WrongAnswer1);
                Answers.Add(question.WrongAnswer2);
                Answers.Add(question.WrongAnswer3);

                Answers = Answers.OrderBy(answer => Guid.NewGuid()).ToList();

                Content = question.Content;

                this.GameId = gameId;

                this.QuestionId = question.Id;
            }
            else
            {
                Answers = null;
            }
        }
    }
}