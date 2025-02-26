using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcerikUretimSistemi.Entites.Abstractions
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            ID = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }
        public Guid ID { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
