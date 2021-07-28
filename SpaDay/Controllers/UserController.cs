using Microsoft.AspNetCore.Mvc;
using SpaDay.Data;
using SpaDay.Models;
using SpaDay.ViewModel;
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
            List<User> newList = new List<User>(UserData.GetAll());
            return View(newList);
        }

        public IActionResult Add()
        {
            AddUserViewModel newModel = new AddUserViewModel();
            return View(newModel);
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel newModel)
        {
            if (ModelState.IsValid)
            {
                if (newModel.VerifyPassword == newModel.Password)
                {
                    User newUser = new User(newModel.Username, newModel.FirstName, newModel.LastName,
                        newModel.Password, newModel.Email);

                    UserData.AddUser(newUser, newModel.VerifyPassword);
                    return Redirect("/User/index");
                }
                else
                {
                    return View(newModel);
                }
            }
            else
            {
                return View(newModel);
            }
        }


    }
}
