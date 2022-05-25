using Microsoft.EntityFrameworkCore;
using s4587831Milestone3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s4587831Milestone3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher_Course>().HasKey(tc => new
            {
                tc.TeacherId,
                tc.CourseId
            });

            modelBuilder.Entity<Teacher_Course>().HasOne(c => c.Course).WithMany(tc => tc.Teachers_Courses).HasForeignKey(c => c.CourseId);
            modelBuilder.Entity<Teacher_Course>().HasOne(c => c.Teacher).WithMany(tc => tc.Teachers_Courses).HasForeignKey(c => c.TeacherId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher_Course> Teachers_Courses { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Convenor> Convenors { get; set; }

        //Orders related tables
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
