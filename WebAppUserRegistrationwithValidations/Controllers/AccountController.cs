﻿using Microsoft.AspNetCore.Mvc;

namespace WebAppUserRegistrationwithValidations.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Signup()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Signup()
        //{
        //    return View();
        //}
    }
}
