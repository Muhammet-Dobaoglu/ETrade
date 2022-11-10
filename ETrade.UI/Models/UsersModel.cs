using ETrade.Entity.Concretes;

namespace ETrade.UI.Models
{
    public class UsersModel
    {
        //user için de county var diye
        public Users ?Users { get; set; }
        public List<County> ?Counties { get; set; }
        public string ?Error { get; set; }


    }
}
