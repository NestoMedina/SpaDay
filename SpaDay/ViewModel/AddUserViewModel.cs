using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage ="Please enter a username")]
        [StringLength(15, MinimumLength = 5)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your first name")]
        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Please enter a password")]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage ="Passwords did not match. Please re - enter your password")]
        public string VerifyPassword { get; set; }


    }
}
