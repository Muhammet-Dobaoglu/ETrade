using ETrade.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Entity.Concretes
{
    public class BaseDescription : IBaseDescription, IBaseTable
    {
        [Key]
        public int Id { get; set; }
        public string Description { get ; set ; }   
    }
}
