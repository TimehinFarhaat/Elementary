using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi1.Entity;


namespace WebApi1.Identity
{
    public class User:BaseEntity
    {
        
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }

        public ICollection<UserRole> UserRoles =new HashSet<UserRole>();

       // public static implicit operator User (DataBuilder<User> v) => throw new NotImplementedException();
    }
}
