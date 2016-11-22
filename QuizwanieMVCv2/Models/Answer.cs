using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizwanieMVCv2.Models
{
    public class Answer
    {
        public int GameId { get; set; }
        public int QuestionId { get; set; }
        public string ChosenAnswer { get; set; }
    }
}