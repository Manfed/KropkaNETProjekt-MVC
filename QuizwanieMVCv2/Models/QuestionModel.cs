using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuizwanieMVCv2.Models
{
    public class QuestionModel
    {

        [Required]
        [Display(Name = "Treść")]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Prawidłowa odpowiedź")]
        public string CorrectAnswer { get; set; }

        [Required]
        [Display(Name = "Błędna odpowiedź nr 1")]
        public string WrongAnswer1 { get; set; }

        [Required]
        [Display(Name = "Błędna odpowiedź nr 2")]
        public string WrongAnswer2 { get; set; }

        [Required]
        [Display(Name = "Błędna odpowiedź nr 3")]
        public string WrongAnswer3 { get; set; }
    }
}