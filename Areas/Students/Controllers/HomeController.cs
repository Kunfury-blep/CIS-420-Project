﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIS_420_Project.Areas.Home.Controllers
{
    public class HomeController : Controller
    {
        [Area("Students")]
        public IActionResult Main()
        {

            return View();
        }

    }
}
