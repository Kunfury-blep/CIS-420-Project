using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIS_420_Project.Areas.Community.Controllers
{
    public class HomeController : Controller
    {
        [Area("Community")]
        public IActionResult Main()
        {
            
            return View();
        }

    }
}
