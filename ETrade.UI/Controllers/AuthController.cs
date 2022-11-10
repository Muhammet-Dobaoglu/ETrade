using ETrade.Entity.Concretes;
using ETrade.UI.Models;
using ETrade.Uw;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ETrade.UI.Controllers
{
    public class AuthController : Controller
    {
        IUow _uow;
        UsersModel _model;
        public AuthController(IUow uow, UsersModel model)
        {
            _uow = uow;
            _model = model;

        }
        public IActionResult List()
        {

            return View(_uow._usersRep.List());
        }

        public IActionResult Register()
        {
            _model.Users = new Users();
            _model.Counties = _uow._countyRep.List();
            return View(_model);
        }
        [HttpPost]
        public IActionResult Register(UsersModel m)
        {//county null baglantı oldugu için
         //şifreli olarak veritabanına kaydediyorum.
     
            m.Users = _uow._usersRep.CreateUser(m.Users);
            if (m.Users.Error == true)//hata
            {
                m.Counties = _uow._countyRep.List();
                m.Error = $"{m.Users.Mail} Kullanıcı mevcut";
                return View(m);
               // return RedirectToAction("Error", "Home", new{ msg = $"{m.Users.Mail}" + $"kullanıcı mevcut"   });

            }
            else
            {
                m.Users.Role = "User";
                _uow._usersRep.Add(m.Users);
                _uow.Commit();
                return RedirectToAction("Index", "Home");

            }

        }
        public IActionResult Login()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Mail,string Password)
        {
            var usr = _uow._usersRep.Login(Mail, Password);
            if(usr.Error==false)
            {
                HttpContext.Session.SetString("User", JsonConvert.SerializeObject(usr));

                if (usr.Role == "Admin")
                {

                   return  RedirectToAction("Index", "Admin");
                }
                else
                {
                   return  RedirectToAction("Index", "Home");
                }
            }


            return View();//loginde kalsın
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
