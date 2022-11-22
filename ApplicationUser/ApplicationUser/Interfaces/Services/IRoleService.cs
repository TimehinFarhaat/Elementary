using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.Identity;


namespace ApplicationUser.Interfaces.Services
{
    public interface  IRoleService
    {
        Role        AddRole (Role    role);
        Role        UpdateRole (Role role);
        bool                   DeleteRole (Role role);
        Role        GetRole (int                id);
        IList<Role> GetRoles ();
        IList<Role> GetSelectedRoles (IList<int> Ids);
    }
}

