using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ApplicationUser.Context;
using ApplicationUser.Identity;
using ApplicationUser.Interfaces.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ApplicationUser.Implementations.Identity
{
    public class UserStore : IUserRepository, IUserStore<User>, IUserPasswordStore<User>,IUserEmailStore<User>,IUserRoleStore<User>
    {
        private readonly ApplicationContext _context;


        public UserStore(ApplicationContext context)
        {
            _context = context;
        }


        public User AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }


        public User UpdateUser(User user)

        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }


        public bool DeleteUser(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
            return true;
        }



        public User GetUser(string userName)
        {
            var user = _context.Users.Include(u => u.ApplicationUserRoles).ThenInclude(v => v.Role).FirstOrDefault(x => x.UserName == userName);
            return user;
        }


        public User GetUser(int id)
        {
            var user = _context.Users.Include(u => u.ApplicationUserRoles).ThenInclude(u => u.Role).SingleOrDefault(i => i.Id == id);
            return user;
        }



        public IList<string> GetRoles(User user)
        {
            var roles = _context.UserRoles.Include(x => x.Role).Where(x => x.User == user).Select(r => r.Role.Name).ToList();

            return roles;

        }



        public IList<User> GetUser()
        {

            var users = _context.Users.Include(u => u.ApplicationUserRoles).ThenInclude(u => u.Role).ToList();
            return users;
        }


       
        public void Dispose()
        {
            _context.Dispose();                                                                             
        }


      
        public Task<string> GetUserIdAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }


            return Task.FromResult(user.Id.ToString());
        }



        public Task<string> GetUserNameAsync(User user, CancellationToken cancellationToken)
        {

            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }


            return Task.FromResult(user.UserName.ToLower());
        }


      
        public Task SetUserNameAsync(User user, string userName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }

            user.UserName = userName.ToLower();
            return Task.CompletedTask;
        }





        public Task<string> GetNormalizedUserNameAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }


            return Task.FromResult(user.UserName.ToLower());
        }





        public Task SetNormalizedUserNameAsync(User user, string normalizedName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }

            user.UserName = normalizedName.ToLower();
            return Task.CompletedTask;
        }





        public async Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }


            await _context.AddAsync(user, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return IdentityResult.Success;
        }





        public async Task<IdentityResult> UpdateAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }

            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync(cancellationToken);
            return IdentityResult.Success;
        }





        public async Task<IdentityResult> DeleteAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }

            _context.Entry(user).State = EntityState.Deleted;
            await _context.SaveChangesAsync(cancellationToken);
            return IdentityResult.Success;
        }




        public async Task<User> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentException(nameof(userId));
            }

            return await _context.Users.FindAsync(new object[] { Guid.Parse(userId), cancellationToken });
        }




        public async Task<User> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (string.IsNullOrEmpty(normalizedUserName))
            {
                throw new ArgumentException(nameof(normalizedUserName));
            }


            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == normalizedUserName, cancellationToken);
        }



        public Task SetPasswordHashAsync(User user, string passwordHash, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }

            return Task.CompletedTask;
        }



        public Task<string> GetPasswordHashAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user.UserName));
            }

            return Task.FromResult(user.PassWord);
        }



        public Task<bool> HasPasswordAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }

            return Task.FromResult(!string.IsNullOrEmpty(user.PassWord));
        }



        
        public Task SetEmailAsync(User user, string email, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }
            user.Email = email.ToLower();
            return Task.CompletedTask;
        }


    

        public Task<string> GetEmailAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user.UserName));
            }

            return Task.FromResult(user.Email.ToLower());
        }


      
        public Task<bool> GetEmailConfirmedAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user.UserName));
            }

            return Task.FromResult(true);
        }


     
        public Task SetEmailConfirmedAsync(User user, bool confirmed, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }
            return Task.CompletedTask;
        }



        public async Task<User> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (string.IsNullOrEmpty(normalizedEmail))
            {
                throw new ArgumentException(nameof(normalizedEmail));
            }

            return await _context.Users.SingleOrDefaultAsync(o => o.Email==normalizedEmail, cancellationToken);
        }





        public Task<string> GetNormalizedEmailAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }

            return Task.FromResult(user.Email.ToLower());
        }




     
        public Task SetNormalizedEmailAsync(User user, string normalizedEmail, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }
            return Task.CompletedTask;
        }





        public async Task AddToRoleAsync(User user, string roleName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }

            var role = await _context.Roles.SingleAsync(r => r.Name == roleName, cancellationToken: cancellationToken);
            await _context.UserRoles.AddAsync(new UserRole
                                         {
                                             ApplicationUserId = user.Id,
                                             ApplicationRoleId = role.Id
                                         },
                                         cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);
        }



        public async  Task RemoveFromRoleAsync(User user, string roleName, CancellationToken cancellationToken)
        {  
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }
            var roles =  _context.UserRoles.Include(x => x.Role)
                                      .Where(u => u.Role.Name == roleName && u.ApplicationUserId==user.Id);
                 _context.UserRoles.RemoveRange(roles);
                 await _context.SaveChangesAsync(cancellationToken);
        }




        public async Task<IList<string>> GetRolesAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }

            var roles = await _context.UserRoles.Include(x => x.Role)
                                      .Where(u => u.ApplicationUserId == user.Id)
                                      .Select(r => r.Role.Name)
                                      .ToListAsync(cancellationToken: cancellationToken);

            return roles;
        }





        public  Task<bool> IsInRoleAsync(User user, string roleName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null)
            {
                throw new ArgumentException(nameof(user));
            }

            var isInRol = _context.UserRoles.Include(u => u.Role)
                                  .Where(x => x.Role.Name == roleName && x.ApplicationUserId == user.Id)
                                  .AnyAsync(cancellationToken: cancellationToken);

            return isInRol;

        }





        public async Task<IList<User>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (roleName == null)
            {
                throw new ArgumentException(nameof(roleName));
            }
            var userRoles = await _context.UserRoles.Include(x => x.Role)
                                           .AsNoTracking()
                                           .Where(u => u.Role.Name == roleName)
                                           .Select(s => s.User)
                                           .ToListAsync(cancellationToken: cancellationToken);

            return userRoles;
        }
    }

}        