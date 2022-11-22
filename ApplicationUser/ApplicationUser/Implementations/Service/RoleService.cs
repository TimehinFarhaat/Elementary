using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.Identity;
using ApplicationUser.Interfaces.Identity;
using ApplicationUser.Interfaces.Services;


namespace ApplicationUser.Implementations.Service
{
    public class RoleService:IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService (IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }


        public Role AddRole (Role role) => throw new NotImplementedException();


  
        public Role UpdateRole (Role role) => throw new NotImplementedException();


      
        public bool DeleteRole (Role role) => throw new NotImplementedException();



        public Role GetRole (int id) => throw new NotImplementedException();



        public IList<Role> GetRoles ()
        {
            var roles = _roleRepository.GetRoles();
            return roles;
        }


        public IList<Role> GetSelectedRoles (IList<int> Ids) => throw new NotImplementedException();
    }
}
