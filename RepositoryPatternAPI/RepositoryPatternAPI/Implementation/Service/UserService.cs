using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using RepositoryPatternAPI.Auth;
using RepositoryPatternAPI.Entities.Identity;
using RepositoryPatternAPI.Interfaces.Services;


namespace RepositoryPatternAPI.Implementation.Service
{
    public class UserService:IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole>    _roleManager;
        private readonly JWT                          _jwt;
        public UserService (UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IOptions<JWT> jwt)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _jwt = jwt.Value;
        }
    }
}
