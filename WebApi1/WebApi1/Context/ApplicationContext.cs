using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Org.BouncyCastle.Bcpg;
using WebApi1.Entity;
using WebApi1.Identity;


namespace WebApi1.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }


        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Student> Students { get; set; } 
        public DbSet<UserRole> UserRoles { get; set; }


        //protected override void OnModelCreating( ModelBuilder modelBuilder)
        //{
        //    var user = modelBuilder.Entity<User>()
        //                           .HasData(
        //                                new User
        //                                {
        //                                    Id = 1,
        //                                    UserName = "wertyuio",
        //                                    Email = "234567890-",
        //                                    PhoneNumber = "asdfghop",
        //                                    Password = "asdfghjkl;",
        //                                    Salt = "AASDFGHJKL;"
        //                                });

        //    var role = modelBuilder.Entity<Role>()
        //                          .HasData(
        //                               new Role
        //                               {
        //                                   Id = 1,
        //                                   Description = "wertyuio",
        //                                   RoleName = "asdfghjkl",

        //                               });
        //   var userRole    =  modelBuilder.Entity<UserRole>().HasData( new UserRole
        //                                {
        //                                    Id =  1,
        //                                    RoleId = 1,
        //                                    UserId = 1,
        //                                });

        //   var students = modelBuilder.Entity<Student>().HasData(new Student
        //                                { 
        //                                    Id = 1,     
        //                                    FirstName ="wertyuio",
        //                                    LastName ="sdfghjll",
        //                                    Address ="dfghjfg",
        //                                    MatricNo=Guid.NewGuid().ToString().Substring(0,4)
        //                            });
        //}


        //public override DatabaseFacade Database => base.Database;

        //public override ChangeTracker ChangeTracker => base.ChangeTracker;

        //public override IModel Model => base.Model;
        //public override DbContextId ContextId => base.ContextId;
    }
}
