using Microsoft.AspNetCore.Mvc;
using SpaDay.Data;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserData = UserData.GetAll();
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }


        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (verify != newUser.pword)
            {
                ViewBag.userinfo = newUser;
                ViewBag.verify = verify;
                return View();
            }
            UserData.AddUser(newUser, verify);
            return Redirect("/User/index");
        }


    }
}
