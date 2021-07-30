using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Models;

namespace TaskManager.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Errand> Errands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> User { get; set; }
        public Context(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserErrand>()
                .HasKey(u => new { u.UserId, u.ErrandId });

            builder.Entity<UserErrand>()
                .HasOne<User>(u => u.User)
                .WithMany(t => t.UserErrand)
                .HasForeignKey(u => u.UserId);
            builder.Entity<UserErrand>()
                .HasOne<Errand>(e => e.Errand)
                .WithMany(t => t.UserErrand)
                .HasForeignKey(t => t.ErrandId);



            //builder.Entity<Category>()
            //    .HasData(new Category { Id = 1, Name = "Prywatne" },
            // new Category { Id = 2, Name = "Grupowe" });

            //builder.Entity<Status>()
            //    .HasData(new Category { Id = 1, Name = "Nieprzydzielone" },
            //             new Category { Id = 2, Name = "Przydzielone" },
            //             new Category { Id = 3, Name = "Konsultacja" },
            //             new Category { Id = 4, Name = "Gotowe" },
            //             new Category { Id = 5, Name = "Anulowane" });
        }
    }
}
