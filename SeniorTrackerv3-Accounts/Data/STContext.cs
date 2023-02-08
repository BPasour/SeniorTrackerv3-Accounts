using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SeniorTrackerv3_Accounts.Models;

namespace SeniorTrackerv3_Accounts.Data
{
    public class STContext : DbContext
    {
        public STContext (DbContextOptions<STContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Benchmark> Benchmarks { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Benchmark>().ToTable("Benchmark");
            modelBuilder.Entity<Teacher>().ToTable("Teacher");
        }
    }
}
