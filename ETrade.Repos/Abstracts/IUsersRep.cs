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
    public interface IUsersRep : IBaseRepository<Users>
    {
      //users tipinde geri döndürülüyorum
     Users CreateUser(Users u);
    UsersDTO Login(string username, string password);   


    }
}
