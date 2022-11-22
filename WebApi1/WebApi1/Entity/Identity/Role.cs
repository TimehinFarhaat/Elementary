using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi1.Entity;


namespace WebApi1.Identity
{
    public class Role:BaseEntity
    {
        
        public string Description { get; set; }
        public string RoleName { get; set; }

        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();

        //public static implicit operator Role (DataBuilder<Role> v) => throw new NotImplementedException();
    }
}
