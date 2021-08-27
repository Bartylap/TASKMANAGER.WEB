using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Domain.Models
{
    public class Construction : ICloneable
    {
        public int Id { get; set; }
        public int Week { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<ConstructionEmployee> ConstructionEmployees { get; set; }
        public virtual ICollection<Car> Car { get; set; }
        public virtual ICollection<Flat> Flat { get; set; }
        public virtual ICollection<Tool> Tolls { get; set; }
        public bool Bufor { get; set; }

        public object Clone()
        {
           return  base.MemberwiseClone();
        }
    }
}
