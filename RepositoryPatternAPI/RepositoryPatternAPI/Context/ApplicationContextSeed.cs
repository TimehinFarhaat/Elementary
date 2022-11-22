
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RepositoryPatternAPI.Entities.Identity;


namespace RepositoryPatternAPI.Context
{
    public class ApplicationContextSeed
    {
        public static async Task SeedEssentialsAsync (UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new Role() { RoleName = RoleConstant.Administrator.ToString(), Description = "Administrator" });
            await roleManager.CreateAsync(new Role(){RoleName = RoleConstant.Moderator.ToString(),Description = "Moderator"});
            await roleManager.CreateAsync(new Role(){RoleName = RoleConstant.User.ToString(),Description = "User"});


             var role=new Role()
             {
                 RoleName = "Backend",
                 Description="Backend developer"
             };
             await roleManager.CreateAsync(role);
            //Seed Default User
            var defaultUser = new User 
            { 
                FirstName = UserConstant.FirstName,
                SurName = UserConstant.SurName,
                PhoneNumber = UserConstant.PhoneNumber,
                Email = UserConstant.Email,
                Password = UserConstant.Password,
                EmailConfirmed = UserConstant.EmailConfirmed,
                PhoneNumberConfirmed = UserConstant.PhoneNumberConfirmed

            };
            if (userManager.Users.All(u => u.Email != defaultUser.Email))
            {
                await userManager.CreateAsync(defaultUser);
                await userManager.AddToRoleAsync(defaultUser,UserConstant.Role.ToString());
            }
        }
    }
}
