using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.Contracts;


namespace ApplicationUser.Identity
{
    public class Role:AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<UserRole> ApplicationUserRoles { get; set; } = new HashSet<UserRole>();
    }
}
