using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizwanieMVCv2.Models
{
    public class UserSignInModel
    {
        public bool IsAuthenticated{ get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }

        public UserSignInModel(bool isAuthenticated)
        {
            new UserSignInModel(isAuthenticated, -1, "None");
        }

        public UserSignInModel(bool isAuthenticated, int userId, string role)
        {
            this.IsAuthenticated = isAuthenticated;
            this.UserId = userId;
            this.Role = role;
        }
    }
}