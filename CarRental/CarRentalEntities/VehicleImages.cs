using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CarRentalEntities
{
    public class VehicleImages
    {
        [Key]
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        
    }
}
