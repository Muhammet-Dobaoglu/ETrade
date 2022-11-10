using ETrade.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Entity.Concretes
{
    public class Products : BaseDescription
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public int VatId { get; set; }

        public int UnitId { get; set; }

        [ForeignKey("CategoryId")]
        public Categories Categories { get; set; }

        [ForeignKey("VatId")]
        public Vat Vat { get; set; }

        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }
        public ICollection<BasketDetail> BasketDetails { get; set; }
    }
}
