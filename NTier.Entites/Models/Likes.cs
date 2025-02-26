using IcerikUretimSistemi.Entites.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Entites.Models
{
    public class Likes:BaseEntity
    {
        public Guid PostID { get; set; }
        public Posts? Posts { get; set; }
        public Guid UserID { get; set; }
        public User? User { get; set; }
    }
}
