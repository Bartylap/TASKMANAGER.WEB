using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Domain.Models
{
    public class UserErrand
    {
        public string UserId { get; set; }
        public MyUser User { get; set; }
        public int ErrandId { get; set; }
        public Errand Errand { get; set; }
        
    }
}
