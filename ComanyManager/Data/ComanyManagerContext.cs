using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ComanyManager.Models;

namespace ComanyManager.Data
{
    public class ComanyManagerContext : DbContext
    {
        public ComanyManagerContext (DbContextOptions<ComanyManagerContext> options)
            : base(options)
        {
        }

        public DbSet<ComanyManager.Models.Employee> Employee { get; set; }

        public DbSet<ComanyManager.Models.Admin> Admin { get; set; }

        public DbSet<ComanyManager.Models.Company> Company { get; set; }

        public DbSet<ComanyManager.Models.Department> Department { get; set; }

        public DbSet<ComanyManager.Models.Profession> Profession { get; set; }
    }
}
