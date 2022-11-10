using ETrade.Dto;
using ETrade.UI.Models;
using ETrade.Uw;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ETrade.UI.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult Index()
        {
            //category unit city
            var usr = JsonConvert.DeserializeObject<UsersDTO>(HttpContext.Session.GetString("User"));
            ViewBag.User = usr.Mail;
            return View();
        }

    }
}
