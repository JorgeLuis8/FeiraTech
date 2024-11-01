using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiraTech.Domain.Entity
{
    public class EntityBase
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool Active { get; set; } = true;
    }
}
