using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    public static class UserStore
    {
        private static List<User> users = new List<User>
        {
            new User { Email = "bilal@gmail.com", Password = "12345" }
        };

        public static bool RegisterUser(string email, string password)
        {
            if (users.Any(u => u.Email == email))
            {
                return false;
            }

            users.Add(new User { Email = email, Password = password });
            return true;
        }

        public static bool ValidateCredentials(string email, string password)
        {
            return users.Any(u => u.Email == email && u.Password == password);
        }
    }

    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
