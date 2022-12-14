using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TwoEntites.Entities;


namespace TwoEntites.Context
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }
}
