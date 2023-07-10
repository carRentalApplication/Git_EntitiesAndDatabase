using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalEntities
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        public string? VehicleName { get; set; }
        public string? VehicleNumber { get; set; }
        public int SeatingCapacity { get; set; }
        public string? FuelType { get; set; }
        public Brand Brand { get; set; }
        public Rent Rent { get; set; }
        public List<VehicleImages> VehicleImages { get; set; }
    }
}
