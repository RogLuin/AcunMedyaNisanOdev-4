using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using static System.Net.Mime.MediaTypeNames;
using Entites;
using Application = Entites.Application;
using EntityConfigurations;
using EntityConfigurations.EntityConfigurations;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Bootcamp> Bootcamps { get; set; }
        public DbSet<Blacklist> Blacklists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationConfiguration());
            modelBuilder.ApplyConfiguration(new BootcampConfiguration());
            modelBuilder.ApplyConfiguration(new BlacklistConfiguration());
        }
    }
}
