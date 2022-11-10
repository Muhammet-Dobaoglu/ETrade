using ETrade.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ETrade.UI.Controllers
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
        public IActionResult Error(string msg)
        {
           // return View (msg); crud gibi algılıyor
           ViewBag.Msg = msg;
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}