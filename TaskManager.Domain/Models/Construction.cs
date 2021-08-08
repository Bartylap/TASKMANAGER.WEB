using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Domain.Models
{
    public class Construction
    {
        public int Id { get; set; }
        public int Week { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Car> Car { get; set; }
        public virtual ICollection<Flat> Flat { get; set; }
        public virtual ICollection<Tool> Tolls { get; set; }

    }
}
