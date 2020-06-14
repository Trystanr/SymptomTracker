using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SQLitePCL;
using SymptomTracker.Factory;
using SymptomTracker.Models;

namespace SymptomTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Test authorization of privacy page
        [Authorize]
        public IActionResult Privacy()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewData["UserID"] = User.FindFirst(type: ClaimTypes.NameIdentifier).Value;
                ViewData["UserName"] = User.FindFirst("lastname").Value;
                ViewData["UserDOB"] = User.FindFirst("dob").Value;

                return View();
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
