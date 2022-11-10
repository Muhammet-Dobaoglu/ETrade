using ETrade.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Entity.Concretes
{
    public class BasketDetail : IBaseTable
    {
        public int Id { get; set; }
        //public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        // Price değişebileceği için çift giriş yapabiliyoruz.
        // (UnitPrice products ta da vardı.) Örneğin elma 5 tl idi. 10 tl olduğu zaman faturada da güncellenecek. Ama biz 5 tl ye almıştık.
        public int Amount { get; set; }
        public decimal Ratio { get; set; }
        public int UnitId { get; set; }

        [ForeignKey("Id")] 
        public BasketMaster BasketMaster { get; set; }

        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }

        [ForeignKey("ProductId")]
        public Products Products { get; set; }
    }
}
