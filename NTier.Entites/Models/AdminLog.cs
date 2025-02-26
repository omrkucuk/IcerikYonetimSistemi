using IcerikUretimSistemi.Entites.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Entites.Models
{
    public class AdminLog : BaseEntity
    {
        public Guid AdminID { get; set; }
        public Admin? Admin { get; set; }
        public string? Action { get; set; }
        public Guid PostID { get; set; }
        public Posts? Posts { get; set; }
        public Guid CommentID { get; set; }
        public Comments? Comment { get; set; }
    }
}
