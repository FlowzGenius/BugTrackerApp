using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTrackerUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BugTrackerUI.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login(LoginModel loginModel)
        {
            JsonResult result = null;

            return result;
        }
    }
}