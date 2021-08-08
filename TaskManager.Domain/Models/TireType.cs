using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Domain.Models
{
    public class TireType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Car> Car { get; set; }
    }
}
