using System.Collections.Generic;

namespace TaskManager.Domain.Models
{
    public class Errand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<MyUserErrand> UserErrand { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
    }
        
}