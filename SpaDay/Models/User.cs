using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string uname { get; set; }
        public string ulname { get; set; }
        public string email { get; set; }
        public string pword { get; set; }

        public DateTime join { get; set; }

        public User()
        {
            this.join = DateTime.Today;
        }

        public User(string uname, string ulname, string email, string pword) : this()
        {
            this.uname = uname;
            this.ulname = ulname;
            this.email = email;
            this.pword = pword;
        }
    }
}
