using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopApp.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        { 
            return View();
        }

       
        public IActionResult RegisterView(string UserName)
        {
            var Coffee = new Registration
            {
                UserName = "",
                email = "",
                Password = "",
                Password2 = ""
            };

            return View(UserName);
        }

        //[HttpPost]
        public IActionResult FinishRegister(string UserName)
        {
            //var UserInfo = (Request.Form[UserName]).ToString();

            //ViewData["UserInfo"] = UserInfo;

            return View(UserName);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
        
}