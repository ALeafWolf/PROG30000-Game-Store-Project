using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Team_WASD___Game_Store_Stock_Management_System.Models;

namespace Team_WASD___Game_Store_Stock_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            return View("Welcome");
        }

        public ViewResult GameList()
        {
            return View();
        }

        [HttpGet]
        public ViewResult SearchGame()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SearchGame(string result)
        {
            return View();
        }

        public ViewResult GameDetails()
        {
            return View();
        }

        public ViewResult EditGameDetails()
        {
            return View();
        }

        /*public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}