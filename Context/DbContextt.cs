using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EF_Task.Configurations;
using EF_Task.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_Task.Context
{
    internal class DbContextt:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= AMR; Database= DbContextt ; Trusted_Connection = True ;");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Student> students { get; set; }
        //Fluent Api

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            //modelBuilder.ApplyConfiguration(new DepatrmentConfiguration());


            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.Entity<Department>()
            //    .HasMany(d => d.Employees)
            //    .WithOne(e => e.Department);

            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.Department)
            //    .WithMany(d => d.Employees);
        }

    }
}
