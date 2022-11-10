using ETrade.Entity.Concretes;
using ETrade.UI.Models;
using ETrade.Uw;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.UI.Controllers
{
    public class CategoriesController : Controller
    {
        IUow _uow;
        CategoriesModel _model;
        public CategoriesController(IUow uow, CategoriesModel model)
        {
            _uow = uow;
            _model = model; 
        }
        public IActionResult List()
        {
            return View(_uow._categoriesRep.List());
        }
        public IActionResult Create()
        {
            _model.Head = "Yeni Giriş";
            _model.Txt = "Kaydet";
            _model.Cls = "btn btn-primary";
            _model.Categories = new Categories();
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Create(CategoriesModel model)
        {
            _uow._categoriesRep.Add(model.Categories);
            _uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Edit(int Id)
        {
            _model.Head = "Güncelle";
            _model.Txt = "Kaydet";
            _model.Cls = "btn btn-success";
            _model.Categories = _uow._categoriesRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Edit(CategoriesModel model)
        {
            _uow._categoriesRep.Update(model.Categories);
            _uow.Commit();
            return RedirectToAction("List");
        }

        public IActionResult Delete(int Id)
        {
            _model.Head = "Silme İşlemi";
            _model.Txt = "Sil";
            _model.Cls = "btn btn-danger";
            _model.Categories = _uow._categoriesRep.Find(Id);
            return View("Crud", _model);
        }
        [HttpPost]
        public IActionResult Delete(CategoriesModel model)
        {
            _uow._categoriesRep.Delete(model.Categories.Id);
            _uow.Commit();
            return RedirectToAction("List");
        }
    }
}
