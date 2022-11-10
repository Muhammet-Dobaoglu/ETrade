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
    public class CityRep<T> : BaseRepository<City>, ICityRep where T : class
    {
        public CityRep(TradeContext db) : base(db)
        {
        }
    }
}
