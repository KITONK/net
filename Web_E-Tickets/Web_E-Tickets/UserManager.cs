using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Web_E_Tickets
{
    public static class UserManager
    {
        private static List<User> Users = new List<User>();
        private static User currentUser = new User();
        
        public static void CreateUser(string password, string name, string surname, float balance)
        {
            if(password is null || name is null || surname is null || balance.ToString() is null)
                throw new RegistrationException("Invalid input");

            User user = new User(password, name, surname, balance);
            Console.WriteLine(user.Name);
            Users.Add(user);
            user.id = Users[Users.Count - 1].id + 1;
        }
        public static bool AuthenticateUser(User user, string pass)
        {
            bool result=false;
            if (!Users.Exists(u => u.id == user.id) || !Users.First(u => u.id == user.id).CheckPassword(pass))
                throw new AuthenticationException("Invalid login/password");
            if (user.CheckPassword(pass) == true)
                result = true;
            
            return result;
        }
        public static void RemoveUser(int _id)
        {
            var user = Users.FirstOrDefault(i => i.id.Equals(_id));
            if (user == null) return;
            if (currentUser == user)
            {
                currentUser = null;
            }
            Users.Remove(user);
        }
        //public static UserManager operator !(UserManager userManager)
        //{
        //    userManager.RemoveUser(userManager.currentUser.id);
        //    return userManager;
        //}

       



    }
}
