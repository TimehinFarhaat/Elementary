using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.Context;
using ApplicationUser.Identity;
using ApplicationUser.Interfaces.Identity;
using Microsoft.EntityFrameworkCore;


namespace ApplicationUser.Implementations.Identity
{
    public class RoleStore:IRoleRepository
    {
        private readonly ApplicationContext _context;


        public RoleStore (ApplicationContext context)
        {
            _context = context;
        }


        public Role AddRole (Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role;
        }



        public Role UpdateRole (Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
            return role;
        }



        public bool DeleteRole (Role role)
        {
            _context.Roles.Remove(role);
            _context.SaveChanges();
            return true;
        }



        public Role GetRole (int id)
        {
            var rol = _context.Roles.Include(x => x.ApplicationUserRoles).
                               ThenInclude(x => x.User).SingleOrDefault(o=>o.Id ==id);
            return rol;
        }



        public IList<Role> GetRoles ()
        {
            var roles = _context.Roles.Include(x => x.ApplicationUserRoles).
                                 ThenInclude(x => x.User).ToList();
            return roles;
        }



        public IList<Role> GetSelectedRoles (IList<int> ids)
        {
            var roles = _context.Roles.Where(x => ids.Contains(x.Id)).ToList();
            return roles;
        }
    }
}
