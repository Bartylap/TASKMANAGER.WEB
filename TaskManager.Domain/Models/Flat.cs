using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Domain.Models
{
    public class Flat
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string FlatNumber { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string RoomsNumber { get; set; }
        public int AvailableCapacity { get; set; }
        public virtual Construction Construction { get; set; }
    }
}
