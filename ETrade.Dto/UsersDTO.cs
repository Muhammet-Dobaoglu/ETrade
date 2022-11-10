using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Dto
{
  public class UsersDTO
    {
        public int Id { get; set; }
        public string ?Mail{ get; set; }
        //public string Password { get; set; }
        public string ?Role { get; set; }
        public bool Error { get; set; }
    }
}
