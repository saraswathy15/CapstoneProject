using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapstoneProject.Models;

namespace CapstoneProject.Data
{
    public class CapstoneProjectDbContext : DbContext
    {
        public CapstoneProjectDbContext (DbContextOptions<CapstoneProjectDbContext> options)
            : base(options)
        {
        }

        public DbSet<CapstoneProject.Models.AdminInfo> AdminInfo { get; set; } = default!;

        public DbSet<CapstoneProject.Models.BlogInfo>? BlogInfo { get; set; }

        public DbSet<CapstoneProject.Models.EmpInfo>? EmpInfo { get; set; }
    }
}
