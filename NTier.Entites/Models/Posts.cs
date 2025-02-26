using IcerikUretimSistemi.Entites.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Entites.Models
{
    public class Posts:BaseEntity
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public Guid UserID { get; set; }
        public User? User { get; set; }

        public ICollection<Comments>? Comments { get; set; } = new List<Comments>();
        public ICollection<Likes>? Likes { get; set; } = new List<Likes>();

    }
}
