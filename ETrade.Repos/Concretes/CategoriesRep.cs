using ETrade.Core;
using ETrade.Dal;
using ETrade.Entity.Concretes;
using ETrade.Repos.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Repos.Concretes
{
    public class CategoriesRep<T> : BaseRepository<Categories>, ICategoriesRep where T : class
    {
        public CategoriesRep(TradeContext db) : base(db)
        {
        }
    }
}
