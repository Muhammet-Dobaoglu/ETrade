using ETrade.Dal;
using ETrade.Repos.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Uw
{
    public class Uow : IUow
    {
        TradeContext _db;
        public IBasketDetailRep _basketDetailRep { get; private set; }

        public IBasketMasterRep _basketMasterRep { get; private set; }

        public ICategoriesRep _categoriesRep { get; private set; }

        public ICityRep _cityRep { get; private set; }

        public ICountyRep _countyRep { get; private set; }

        public IProductsRep _productsRep { get; private set; }

        public ISuppliersRep _suppliersRep { get; private set; }

        public IUnitRep _unitRep { get; private set; }

        public IUsersRep _usersRep { get; private set; }

        public IVatRep _vatRep { get; private set; }

        public void Commit()
        {
            _db.SaveChanges();
        }
        public Uow(TradeContext db, IBasketDetailRep basketDetailRep, IBasketMasterRep basketMasterRep, ICategoriesRep categoriesRep, ICityRep cityRep, ICountyRep countyRep, IProductsRep productsRep, ISuppliersRep suppliersRep, IUnitRep unitRep, IUsersRep usersRep, IVatRep vatRep)
        {
            _db = db;
            _basketDetailRep = basketDetailRep;
            _basketMasterRep = basketMasterRep;
            _categoriesRep = categoriesRep;
            _cityRep = cityRep;
            _countyRep = countyRep;
            _productsRep = productsRep;
            _suppliersRep = suppliersRep;
            _unitRep = unitRep;
            _usersRep = usersRep;
            _vatRep = vatRep;
        }
    }
}
