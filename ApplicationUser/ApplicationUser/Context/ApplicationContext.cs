using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationUser.Entities;
using ApplicationUser.Identity;
using Microsoft.EntityFrameworkCore;


namespace ApplicationUser.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
