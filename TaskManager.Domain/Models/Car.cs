using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Domain.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public string Seats { get; set; }
        public string Year { get; set; }
        public DateTime CarInsurance { get; set; }
        public DateTime CarReview { get; set; }
        public string Tires { get; set; }
        public Construction Construction { get; set; }
        public virtual TireType TireType { get; set; }
    }
}
