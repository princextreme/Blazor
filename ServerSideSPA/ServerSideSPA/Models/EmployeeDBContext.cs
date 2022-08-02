using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace ServerSideSPA.Models
{
    public partial class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext()
        {
        }

        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<DailyWork> DailyWorks { get; set; } = null!;
        public virtual DbSet<Collaborator> Collaborators { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<SubCategory> SubCategories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubCategory>()
       .HasKey(c => c.SubCategoryId);
       //     modelBuilder.Entity<Project>()
       //.HasMany(c => c.SubCategories)
       // .WithOne(e => e.Project)
       //.OnDelete(DeleteBehavior.SetNull)
       //.IsRequired(true);
            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.ProjectId ).HasColumnName("ProjectId");

                entity.Property(e => e.ProjectTitle) 
                    .IsUnicode(false);
                entity.HasKey(e => e.ProjectId); 
            });



            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");
                entity.HasKey(e => e.CityId);
                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
       //     modelBuilder.Entity<DailyWork>()
       //.HasMany(c => c.Collaborators)
       // .WithOne(e => e.DailyWork)
       //.OnDelete(DeleteBehavior.SetNull)
       //.IsRequired(false)
       //.HasForeignKey(e=>new {e.EmpId,e.EntryBy})
       // ;
            modelBuilder.Entity<DailyWork>(entity =>
            {
                entity.ToTable("DailyWork");
                entity.HasKey(e => e.WorkId);

                entity.Property(e => e.WorkId).HasColumnName("WorkId");
                entity.Property(e => e.EntryDate )
                    .HasDefaultValueSql("GETDATE()");
                entity.Property(e => e.WStatus)
                    .HasDefaultValue(1);
                

            });
            

            modelBuilder.Entity<Collaborator>(entity =>
            {
                entity.ToTable("Collaborator");
                entity.HasKey(e => e.CollaborationId);
                entity.Property(e => e.CollaborationId).HasColumnName("CollaborationId");
                //entity.HasMany(e => e.DailyWork);

            });
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");
                entity.HasKey(e => e.EmployeeId);
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
