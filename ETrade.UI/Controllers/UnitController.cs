using ETrade.Entity.Concretes;
using ETrade.UI.Models;
using ETrade.Uw;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class UnitController : Controller
    {
        IUow _uow;
         UnitModel _model;
        public UnitController(IUow uow, UnitModel model)
        {
            _uow = uow;
            _model = model;
        }

        public IActionResult List()
        {
            var clist = _uow._unitRep.List();
            return View(clist);
        }

        public IActionResult Create()
        {
            _model.Head = "Yeni Giriş";
            _model.Txt = "Kaydet";
            _model.Cls = "btn btn-primary";
            _model.Unit = new Unit();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(UnitModel model)
        {
            _uow._unitRep.Add(model.Unit);
            _uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Edit(int Id)
        {
            _model.Head = "Güncelle";
            _model.Txt = "Kaydet";
            _model.Cls = "btn btn-success";
            _model.Unit = _uow._unitRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(UnitModel model)
        {
            _uow._unitRep.Update(model.Unit);
            _uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Delete(int Id)
        {
            _model.Head = "Silme İşlemi";
            _model.Txt = "Sil";
            _model.Cls = "btn btn-danger";
            _model.Unit = _uow._unitRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(UnitModel model)
        {
            _uow._unitRep.Delete(model.Unit.Id);
            _uow.Commit();
            return RedirectToAction("List");
        }
    }
}

