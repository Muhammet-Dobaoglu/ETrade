using ETrade.Dto;
using ETrade.Entity.Concretes;

namespace ETrade.UI.Models
{
    public class BasketDetailModel
    {
   // public BasketDetail? BasketDetail { get; set; }
       public List<BasketDetailDTO> BasketDetailDTO { get; set; }
        public List<ProductSDTO> ProductsDTO { get; set; }
        public int ProductId { get; set; }  
        public int Id { get; set; }
        public decimal UnitPrice { get; set; }
        public int Amount { get; set; }
        public int UnitId { get; set; }
        public decimal Ratio { get; set; }
       
    }
}
