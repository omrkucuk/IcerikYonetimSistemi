using IcerikUretimSistemi.Entites.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Entites.Models
{
    public class Follows:BaseEntity
    {
        public Guid FollowerID { get; set; }
        public Users? Follower { get; set; }
        public Guid FollowingID { get; set; }
        public Users? Following { get; set; }
    }
}
