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

        // Kullanıcıyı oturum açtığında set etmek için bir metod
        public static void SetCurrentUser(User user)
        {
            LoggedInUser = user;
        }

        // Kullanıcıyı oturum kapattığında null yapabiliriz
        public static void Logout()
        {
            LoggedInUser = null;
        }
    }

}
