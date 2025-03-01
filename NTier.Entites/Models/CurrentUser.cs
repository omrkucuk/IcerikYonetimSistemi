using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Entites.Models
{
    public static class CurrentUser
    {
        // Statik bir özellik olarak giriş yapmış kullanıcıyı saklar
        public static User LoggedInUser { get; set; }

        public static void LogIn(User user)
        {
            LoggedInUser = user;
        }

        public static User GetUser()
        {
            return LoggedInUser;
        }

        public static void Logout()
        {
            LoggedInUser = null;
        }
    }

}
