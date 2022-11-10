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
    public interface IBasketDetailRep : IBaseRepository<BasketDetail>
    {
        //ilgili userın enttiy id olur
        //login olmuş userıd
        //userıd masterıd oluyor okuma kolaylığı olsun diye
        List<BasketDetailDTO> basketDetailDTOs(int MasterId);
    }
}
