using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Domain.Models
{
    public class MyUserErrand
    {
        public string MyUserId { get; set; }
        public MyUser User { get; set; }
        public int ErrandId { get; set; }
        public Errand Errand { get; set; }
        
    }
}
