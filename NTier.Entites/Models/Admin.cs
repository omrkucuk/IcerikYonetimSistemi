using IcerikUretimSistemi.Entites.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Entites.Models
{
    public class Admin:BaseEntity
    {
        public bool CanManagersUsers { get; set; } = true;
        public bool CanEditPosts { get; set; } = true;
        public bool CanDeletePosts { get; set; } = true;
    }
}
