using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.Contracts;
using ApplicationUser.Entities;


namespace ApplicationUser.Identity
{
    public class User    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public ICollection<UserRole> ApplicationUserRoles { get; set; } = new HashSet<UserRole>();
    }
}
