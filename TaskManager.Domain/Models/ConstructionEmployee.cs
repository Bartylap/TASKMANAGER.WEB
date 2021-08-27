using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Domain.Models
{
    public class ConstructionEmployee
    {
        public int ConstructionId { get; set; }
        public virtual Construction Construction { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int Week { get; set; }
    }
}
