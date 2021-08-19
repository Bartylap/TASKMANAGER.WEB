using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Domain.Models
{
    public class Employee 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public string Position { get; set; }
        public int HourlyRate { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public DateTime DateOfRelease { get; set; }
        public ICollection<ConstructionEmployee> ConstructionEmployees { get; set; }
        public virtual ICollection<EmployeeAddress> EmployeeAddress { get; set; }
        public virtual ICollection<EmployeeContact> EmployeeContact { get; set; }
    }
}
