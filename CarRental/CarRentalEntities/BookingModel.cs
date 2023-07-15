using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalEntities
{
    public class BookingModel
    {
        public string TravallerName { get; set; }
        public long TravallerNumber { get; set; }
        public string PickUpDate { get; set; }
        public string DropDate { get; set; }
        public string PickUpAddress { get; set; }
        public string PaymentMode { get; set; }
        public double TotalAmount { get; set; }
        public int VehicleId { get; set; }
        public string userId { get; set; }
    }
}