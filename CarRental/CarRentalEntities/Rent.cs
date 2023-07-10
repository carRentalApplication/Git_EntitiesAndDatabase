using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalEntities
{
    public class Rent
    {
        [Key]
        public int RentId { get; set; }
        public double RentAmount { get; set; }
    }
}
