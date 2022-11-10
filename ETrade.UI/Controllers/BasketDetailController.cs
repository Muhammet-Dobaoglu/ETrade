using ETrade.Entity.Concretes;
using ETrade.UI.Models;
using ETrade.Uw;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace ETrade.UI.Controllers
{
    public class BasketDetailController : Controller
    {
        //program.cs basketdetail tanımla.
        BasketDetail _basketDetail;
        BasketDetailModel _basketDetailModel;
        IUow _uow;
        public BasketDetailController(BasketDetail basketDetail, IUow uow,BasketDetailModel basketDetailModel)
        {
           _basketDetail = basketDetail;
            _uow = uow;
            _basketDetailModel = basketDetailModel;  
        }

        public IActionResult Add(int id)
        {//boş empty

            _basketDetailModel.ProductsDTO = _uow._productsRep.GetProductsSelect();
            _basketDetailModel.BasketDetailDTO = _uow._basketDetailRep.basketDetailDTOs(id);


            return View(_basketDetailModel);

        }
        [HttpPost]
        public IActionResult Add(BasketDetailModel m,int id)
        {


            Products yeniproduct = _uow._productsRep.FindWithVAT(m.ProductId);
            _basketDetail.Amount = m.Amount;
            _basketDetail.ProductId = m.ProductId;
            _basketDetail.Id = id;
            //boş geliyor unit tablosundan sectik 
            _basketDetail.UnitId = yeniproduct.UnitId;
            _basketDetail.Ratio = yeniproduct.Vat.Ratio;
            _basketDetail.UnitPrice = yeniproduct.UnitPrice;
           _uow._basketDetailRep.Add(_basketDetail);
            _uow.Commit();
         
            return RedirectToAction("Add",new {id});
    

        }

        public IActionResult Delete(int Id,int productId)
        {
            _uow._basketDetailRep.Delete(Id, productId);
            _uow.Commit();
            return RedirectToAction("Add", new {Id});
        }


        


    }
}
