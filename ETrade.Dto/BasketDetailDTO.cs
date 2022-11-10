using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto
{
   public class BasketDetailDTO
    {

       // public List<ProductSDTO> ProductSDTOs { get; set; }
     //   public List<BasketDetailDTO> BasketDetailDTOs { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Amonut { get; set; }
        public string UnitName { get; set; }
   
        public decimal  Vat { get; set; }
        public decimal Total { get; set; }
        public int Id { get; set; }
        public int ProductId { get; set; }




    }
}
