using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ApplicationUser.Identity;
using ApplicationUser.Interfaces.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;


namespace ApplicationUser.Implementations.Identity
{
    public class IdentityService:IIdentityService
    {
        private readonly IUserRepository _userRepository;
        private readonly IHttpContextAccessor _context;
        private readonly IConfiguration _configuration;
        public IdentityService (IUserRepository userRepository, IConfiguration configuration, IHttpContextAccessor context)
        {
            _userRepository = userRepository;
            _configuration = configuration;
            _context = context;
        }





        public User FindByName (string userName)
        {
            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName));
            }
            var user = _userRepository.GetUser(userName);
            return user;
        }





        public bool CheckPassword (User user, string password)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            if (user.PassWord != password)
            {
                return false;
            }

            return true;
        }






        public IList<string> GetRoles (User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            var roles = _userRepository.GetRoles(user);
            return roles;
        }






        public void SetClaims (User user, IEnumerable<string> roles)
        {
            IList<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(ClaimTypes.Name,user.UserName),
              //  new Claim(ClaimTypes.Email,user.Email)
            };

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var claimsIdentity=new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
            var authenticationProperties=new AuthenticationProperties();
            var principal=new ClaimsPrincipal(claimsIdentity);
            _context.HttpContext?.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);
        }






        public string GetUserIdentity ()
        {
            var user = _context.HttpContext?.User?.FindFirst(
                                    ClaimTypes.NameIdentifier)
                              ?.Value;

            return user;
        }
    }
}
