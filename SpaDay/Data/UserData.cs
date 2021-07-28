using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Data
{
    public class UserData
    {
        private static Dictionary<string, User> _userList = new Dictionary<string, User>();

        public static void AddUser(User newUser, string verify)
        {
            if (verify == newUser.Password)
            {
            _userList.Add(newUser.Email, newUser);
            }
        }

        public static IEnumerable<User> GetAll()
        {
            return _userList.Values;
        }


    }
}
