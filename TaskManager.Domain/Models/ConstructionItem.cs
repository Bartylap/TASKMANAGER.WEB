using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Domain.Models
{
    public class ConstructionItem
    {
        public int ConstructionId { get; set; }
        public virtual Construction Construction { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
