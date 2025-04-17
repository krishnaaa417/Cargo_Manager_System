using CargoManager.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoManager.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<CargoTracking> CargoTrackings { get; set; }

        public DbSet<PaymentOrder> PaymentOrders { get; set; }

        public DbSet<Payment> Payments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // I'm trying to create a FK relation ship code down so it will be easy to what happending inside this thingss

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Cargos)
                .WithOne(cg => cg.Customer)
                .HasForeignKey(cg => cg.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cargo → CargoTracking (One-to-Many)
            modelBuilder.Entity<CargoTracking>()
                .HasOne(ct => ct.Cargo)
                .WithMany(c => c.Trackings)
                .HasForeignKey(ct => ct.CargoId)
                .OnDelete(DeleteBehavior.Cascade);
        }


    }
}
