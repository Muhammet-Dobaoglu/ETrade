using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Entity.Concretes
{
    public class Categories : BaseDescription
    {
        public ICollection<Products> Products { get; set; }
    }
}
