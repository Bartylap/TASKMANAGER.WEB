using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Domain.Models
{
    public class EmployeeAddress
    {
        public int Id { get; set; }
        public string AdressLine1 { get; set; }
        public string BuildingNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
