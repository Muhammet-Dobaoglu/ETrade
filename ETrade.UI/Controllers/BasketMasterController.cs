using ETrade.Dto;
using ETrade.Entity.Concretes;
using ETrade.UI.Models;
using ETrade.Uw;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;

namespace ETrade.UI.Controllers
{
    public class BasketMasterController : Controller
    {
        //view olmucak
        //herşey otomatik
        //program cs de
        //builder.Services.AddScoped<BasketMaster>(); 
        IUow _uow;
        BasketMaster _basketMaster;
        public BasketMasterController(IUow uow,BasketMaster basketMaster)
        {
             _uow = uow;
            _basketMaster = basketMaster;
        }
        public IActionResult Create()
        {
            var user = JsonConvert.DeserializeObject<UsersDTO>(HttpContext.Session.GetString("User"));
            var selectedMaster = _uow._basketMasterRep.Set().FirstOrDefault(x => x.Completed == false && x.EntityId==user.Id);
            if(selectedMaster != null)//varsa
            {
                return RedirectToAction("Add", "BasketDetail", new { id = selectedMaster.Id });

            }
            else //yoksa sepete ekliyor
            {
          
                _basketMaster.OrderDate = DateTime.Now;
                _basketMaster.EntityId = user.Id;//id
                _uow._basketMasterRep.Add(_basketMaster);
                _uow.Commit();
                return RedirectToAction("Add", "BasketDetail", new { id = _basketMaster.Id });
                //id otomatik atamıyor.biz verdik

            }
      
        }
       
      
    }
}
