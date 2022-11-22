using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternAPI.Entities.Identity
{
    public class Role:BaseEntity
    {
        
        public string Description { get; set; }
        public string RoleName { get; set; }
       
        public ICollection<UserRole> UserRoles { get; set; }=new HashSet<UserRole>();
    }
}
