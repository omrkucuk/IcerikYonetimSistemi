using IcerikUretimSistemi.Entites.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Entites.Models
{
    public class Message
    {
        public Message()
        {
            ID = Guid.NewGuid();
            SendAt = DateTime.Now;
            IsRead = false;
        }
        public Guid ID { get; set; }
        public Guid SenderID { get; set; }
        public User Sender { get; set; }
        public Guid ReceiverID { get; set; }
        public User Receiver { get; set; }
        public string? Content { get; set; }
        public DateTime SendAt { get; set; } 
        public bool IsRead { get; set; }
    }
}
