using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalEntities
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string TravellerName { get; set; }
        public long TravellerNumber { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropDate { get; set; }
        public DateTime BookingTime { get; set; }
        public string PickUpAddress { get; set; }
        public double AdvanceAmount { get; set; }
        public double TotalAmount { get; set; }
        public Status Status { get; set; }

        public Vehicle Vehicle { get; set; }
        public AuthUser AuthUser { get; set; }
        public PaymentType PaymentType { get; set; }

    }
}
