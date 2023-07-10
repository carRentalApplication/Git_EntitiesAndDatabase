using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalEntities
{
    public class AuthUser
    {
        [Key]
        public Guid UserId { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public long MobileNumber { get; set; }
        public string Role { get; set; } = string.Empty;
        public DateTime MemberSince { get; set; }
    }
}
