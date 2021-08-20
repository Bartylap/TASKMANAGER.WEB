using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TaskManager.Domain.Models
{
    public class Employee 
    {
        public Employee()
        {
        }

        public Employee(int id, string firstName, string lastName, string pesel, string position, int hourlyRate, DateTime birthDate, DateTime dateOfEmployment, DateTime dateOfRelease, ICollection<ConstructionEmployee> constructionEmployees, ICollection<EmployeeAddress> employeeAddress, ICollection<EmployeeContact> employeeContact)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
            Position = position;
            HourlyRate = hourlyRate;
            BirthDate = birthDate;
            DateOfEmployment = dateOfEmployment;
            DateOfRelease = dateOfRelease;
            ConstructionEmployees = constructionEmployees;
            EmployeeAddress = employeeAddress;
            EmployeeContact = employeeContact;
        }

        [XmlAttribute("Id")]
        public int Id { get; set; }
        [XmlElement("FirstName")]
        public string FirstName { get; set; }
        [XmlElement("LastName")]
        public string LastName { get; set; }
        [XmlElement("Pesel")]
        public string Pesel { get; set; }
        [XmlElement("Position")]
        public string Position { get; set; }
        [XmlElement("HourlyRate")]
        public int HourlyRate { get; set; }
        [XmlIgnore]
        public DateTime BirthDate { get; set; }
        [XmlIgnore]
        public DateTime DateOfEmployment { get; set; }
        [XmlIgnore]
        public DateTime DateOfRelease { get; set; }
        [XmlIgnore]
        public ICollection<ConstructionEmployee> ConstructionEmployees { get; set; }
        [XmlIgnore]
        public virtual ICollection<EmployeeAddress> EmployeeAddress { get; set; }
        [XmlIgnore]
        public virtual ICollection<EmployeeContact> EmployeeContact { get; set; }
    }
}
