﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIS_420_Project.Areas.Students.Controllers
{
    public class IrisController : Controller
    {
        [Area("Students")]
        public IActionResult Main()
        {
            return View();
        }

    }
}
