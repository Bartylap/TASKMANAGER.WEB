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
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
        public DbSet<EmployeeContact> EmployeeContacts { get; set; }
        public DbSet<Flat> Flats { get; set; }
        public DbSet<TireType> TireTypes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Errand> Errands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<MyUser> MyUsers { get; set; }
        public DbSet<MyUserErrand> MyUserErrands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Construction> Constructions { get; set; }
        public DbSet<ConstructionEmployee> ConstructionEmployee { get; set; }
        public DbSet<ConstructionItem> ConstructionItem { get; set; }
        public Context(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<MyUserErrand>()
                .HasKey(u => new { u.MyUserId, u.ErrandId });

            builder.Entity<MyUserErrand>()
                .HasOne<MyUser>(u => u.MyUser)
                .WithMany(t => t.MyUserErrand)
                .HasForeignKey(u => u.MyUserId);
            builder.Entity<MyUserErrand>()
                .HasOne<Errand>(e => e.Errand)
                .WithMany(t => t.UserErrand)
                .HasForeignKey(t => t.ErrandId);

            //------------------------------------------------//
            builder.Entity<ConstructionEmployee>()
                .HasKey(e => new { e.ConstructionId, e.EmployeeId });

            builder.Entity<ConstructionEmployee>()
                .HasOne<Construction>(c => c.Construction)
                .WithMany(e => e.ConstructionEmployees)
                .HasForeignKey(f => f.ConstructionId);
            builder.Entity<ConstructionEmployee>()
                .HasOne<Employee>(e => e.Employee)
                .WithMany(c => c.ConstructionEmployees)
                .HasForeignKey(f => f.EmployeeId);

            //------------------------------------------------//

            builder.Entity<ConstructionItem>()
    .HasKey(e => new { e.ConstructionId, e.ItemId });

            builder.Entity<ConstructionItem>()
                .HasOne<Construction>(c => c.Construction)
                .WithMany(e => e.ConstructionItems)
                .HasForeignKey(f => f.ConstructionId);
            builder.Entity<ConstructionItem>()
                .HasOne<Item>(e => e.Item)
                .WithMany(c => c.ConstructionItems)
                .HasForeignKey(f => f.ItemId);




            builder.Entity<Category>()
                .HasData(new Category { Id = 1, Name = "Prywatne" },
             new Category { Id = 2, Name = "Grupowe" });

            builder.Entity<Status>()
                .HasData(new Status { Id = 1, Name = "Nieprzydzielone" },
                         new Status { Id = 2, Name = "Przydzielone" },
                         new Status { Id = 3, Name = "Konsultacja" },
                         new Status { Id = 4, Name = "Gotowe" },
                         new Status { Id = 5, Name = "Anulowane" });
        }
    }
}
