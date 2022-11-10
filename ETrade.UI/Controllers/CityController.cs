using ETrade.Dal;
using ETrade.Entity.Concretes;
using ETrade.UI.Models;
using ETrade.Uw;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class CityController : Controller
    {
        IUow _uow;
        CityModel _model;
        public CityController(IUow uow, CityModel model)
        {
            _uow = uow;
            _model = model;
        }

        public IActionResult List()
        {
            var clist = _uow._cityRep.List();
            return View(clist);
        }
        
        public IActionResult Create()
        {
            _model.Head = "Yeni Giriş";
            _model.Txt = "Kaydet";
            _model.Cls = "btn btn-primary";
            _model.City = new City();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(CityModel model)
        {
            _uow._cityRep.Add(model.City);
            _uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Edit(int Id)
        {
            _model.Head = "Güncelle";
            _model.Txt = "Kaydet";
            _model.Cls = "btn btn-success";
            _model.City = _uow._cityRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(CityModel model)
        {
            _uow._cityRep.Update(model.City);
            _uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Delete(int Id)
        {
            _model.Head = "Silme İşlemi";
            _model.Txt = "Sil";
            _model.Cls = "btn btn-danger";
            _model.City = _uow._cityRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(CityModel model)
        {
            _uow._cityRep.Delete(model.City.Id);
            _uow.Commit();
            return RedirectToAction("List");
        }
    }
}
