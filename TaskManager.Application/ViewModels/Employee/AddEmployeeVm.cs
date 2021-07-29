using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.ViewModels.Employee
{
    public class AddEmployeeVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pesel { get; set; }
        public string Position { get; set; }
    }
}
