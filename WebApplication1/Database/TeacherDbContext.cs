﻿using WebApplication1.Database.Configurations;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Database
{
    public class TeacherDbContext : DbContext
    {
        DbSet<Teacher> Teachers { get; set; }
        DbSet<AcademicDegree> AcademicDegrees { get; set; }
        DbSet<Department> Departments { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        DbSet<Position> Positions { get; set; }
        DbSet<TeachingLoad> TeachingLoads { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new AcademicDegreeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new PositionConfiguration());
            modelBuilder.ApplyConfiguration(new TeachingLoadConfiguration());
        }

        public TeacherDbContext(DbContextOptions<TeacherDbContext> options) : base(options)
        {
        }
    }
}
