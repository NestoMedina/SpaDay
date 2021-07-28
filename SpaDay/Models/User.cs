using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public DateTime join { get; set; }

        public User()
        {
            this.join = DateTime.Now;
        }

        public User(string uname, string fname, string lname, string pword, string email) : this()
        {
            this.Username = uname;
            this.FirstName = fname;
            this.LastName = lname;
            this.Password = pword;
            this.Email = email;

        }
    }
}
