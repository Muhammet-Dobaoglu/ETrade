using ETrade.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Entity.Concretes
{
    public class BasketMaster : IBaseTable
    {
        public int Id { get ; set ; }
        public DateTime OrderDate { get; set; }
        public int EntityId { get; set; }
        public ICollection<BasketDetail> BasketDetails { get; set; }

        [ForeignKey("EntityId")]
        public Users Users { get; set; }
        public bool Completed { get; set; }
    }
}
