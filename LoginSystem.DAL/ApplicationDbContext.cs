using LoginSystem.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<User>(builder =>
            {
                builder.Property(x => x.Id).ValueGeneratedOnAdd();
                builder.Property(x => x.Password).IsRequired();
                builder.Property(x => x.Name).IsRequired();
            });
        }
    }
}
