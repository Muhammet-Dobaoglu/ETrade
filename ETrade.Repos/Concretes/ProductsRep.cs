using ETrade.Core;
using ETrade.Dal;
using ETrade.Dto;
using ETrade.Entity.Concretes;
using ETrade.Repos.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Repos.Concretes
{
    public class ProductsRep<T> : BaseRepository<Products>, IProductsRep where T : class
    {
        public ProductsRep(TradeContext db) : base(db)
        {
        }

        public Products FindWithVAT(int Id)
        {
            //lazy loading
            //select de include kendi ediyor
          return Set().Where(x=>x.Id==Id).Include(x=>x.Vat).FirstOrDefault();
        }

        public List<ProductSDTO> GetProductsSelect()
        {
            return Set().Select(x =>new ProductSDTO { Id = x.Id, ProductName = x.ProductName }).ToList();
        }
    }
}
