using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.Identity;


namespace ApplicationUser.Interfaces.Identity
{
    public interface IUserRepository
    {
        User        AddUser (User    user);
        User        UpdateUser (User user);
        bool        DeleteUser (User user);
        User        GetUser (string    userName);
        User        GetUser (int   id);
        public IList<string>   GetRoles (User   user);
        IList<User> GetUser ();
    }
}
