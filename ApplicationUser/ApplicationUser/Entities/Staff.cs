using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.Contracts;
using ApplicationUser.Identity;


namespace ApplicationUser.Entities
{
    public class Staff:AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string staffNumber { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
