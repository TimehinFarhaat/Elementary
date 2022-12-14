using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace RepositoryPatternAPI.Entities.Identity
{
    public class User:BaseEntity
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string  Salt { get; set; }
        public ICollection<UserRole> UserRoles=new HashSet<UserRole>();
    }
}
