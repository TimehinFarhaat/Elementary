using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.Identity;


namespace ApplicationUser.Interfaces.Identity
{
    public interface  IIdentityService
    {
        User FindByName (string              userName);
        bool       CheckPassword (User  user, string password);
        IList<string>   GetRoles (User       user);
        void       SetClaims (User user, IEnumerable<string> roles);
        string      GetUserIdentity ();

    }
}
