﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EasyMaintain.CoreWebMVC.Utility;

namespace EasyMaintain.CoreWebMVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            if (SessionUtility.utilityToken.AccessToken == null)
            {
                return RedirectToAction("Login", "Account", new { area = "" });
            }
            else {
                return View(SessionUtility.utilityUserdataModel);
            }
        }
    }
}
