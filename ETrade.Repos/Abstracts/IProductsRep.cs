using ETrade.Core;
using ETrade.Dto;
using ETrade.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Repos.Abstracts
{
    public interface IProductsRep : IBaseRepository<Products>
    {
        List<ProductSDTO> GetProductsSelect();
        Products FindWithVAT(int Id);//lazy loading

            
    }
}
