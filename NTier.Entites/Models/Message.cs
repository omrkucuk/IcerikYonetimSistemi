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
        }
        public Guid ID { get; set; }
        public Guid SenderID { get; set; }
        public Users Sender { get; set; }
        public Guid ReceiverID { get; set; }
        public Users Receiver { get; set; }
        public string? Content { get; set; }
        public DateTime SendAt { get; set; }
        public bool IsRead { get; set; }
    }
}
