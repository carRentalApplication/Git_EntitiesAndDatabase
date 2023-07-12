using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalEntities
{
    public class UpdateAuthStatus
    {
        public Guid Id { get; set; }

        public string Status { get; set; } = string.Empty;
    }
}
