using Microsoft.EntityFrameworkCore;
using SchoolAPI.Models;
using System.Reflection;


namespace SchoolAPI
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {
        }
        public SchoolContext(DbContextOptions<SchoolContext> options): base(options)
        {   
        }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentInClass> StudentInClasses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=school.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Class>().ToTable("Class");
            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey(e => e.ClassID);
                entity.Property(e => e.ClassName);
            });
            //modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudentID);
                entity.Property(e => e.StudentName);
            });
            //modelBuilder.Entity<StudentInClass>().ToTable("StudentInClass");
            modelBuilder.Entity<StudentInClass>(entity =>
            {
                entity.HasKey(e => e.SCID);
                entity.Property(e => e.ClassID);
                entity.Property(e => e.StudentID);
            });
            //modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);

        }

    }
}
