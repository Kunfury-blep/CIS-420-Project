using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIS_420_Project.Areas.Researchers.Controllers
{
    public class HomeController : Controller
    {
        [Area("Researchers")]
        public IActionResult Main()
        {
            string blep = "Aaron";
            string blep1 = "TayTay";
            return View();
        }
    }
}
