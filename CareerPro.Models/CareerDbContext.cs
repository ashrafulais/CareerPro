using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareerPro.Model
{
    public class CareerDbContext : IdentityDbContext<AppUser>
    {
        public CareerDbContext(DbContextOptions<CareerDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>()
                .HasOne(o => o.PostedByUser)
                .WithMany()
                .HasForeignKey(f => f.PostedByID);

            modelBuilder.Entity<Job>()
                .HasOne(o => o.Category)
                .WithMany()
                .HasForeignKey(f => f.CategoryID);

            //map keys to the .net core identity
            //because we are overriding the method, we need to specify it in the base method
            base.OnModelCreating(modelBuilder);

            //use this code to enforce not to delete a record that contains foreign key connection (User , Roles , UserRoles : tables)

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                                        .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }

            //load initial data into db
            modelBuilder.LoadSeedData();
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<Job> Jobs  { get; set; }
    }
}
