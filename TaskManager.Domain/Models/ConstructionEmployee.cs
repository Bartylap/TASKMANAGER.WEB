using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Domain.Models
{
    public class ConstructionEmployee
    {
        public int ConstructionId { get; set; }
        public Construction Construction { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int Week { get; set; }
    }
}
