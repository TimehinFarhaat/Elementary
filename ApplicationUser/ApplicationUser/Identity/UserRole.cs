using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.Contracts;


namespace ApplicationUser.Identity
{
    public class UserRole :AuditableEntity
    {
        public int ApplicationUserId { get; set; }
        public User User { get; set; }
        public int ApplicationRoleId { get; set; }
        public Role Role { get; set; }
    
    }
}
