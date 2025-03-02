using IcerikUretimSistemi.Entites.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Entites.Models
{
    public class Follow : BaseEntity
    {
        public Guid FollowerID { get; set; }
        public virtual User? Follower { get; set; } // Takip eden kişi

        public Guid FollowingID { get; set; }
        public virtual User? Following { get; set; } // Takip edilen kişi
    }

}
