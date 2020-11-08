using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CIS_420_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace CIS_420_Project.Controllers
{
    public class HomeController : Controller
    {
        private ORI_WEB_NEWContext _db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ORI_WEB_NEWContext context, ILogger<HomeController> logger)
        {
            _logger = logger;
            _db = context;
        }

        public IActionResult Main()
        {
            return View(_db.Users.ToList());
        }

        public IActionResult Calendar()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult Community()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
