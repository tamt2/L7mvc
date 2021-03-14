using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        //tinfo200:[2021-03-13-tamt2-dykstra2] - inherit from DbContext
        //tinfo200:[2021-03-13-tamt2-dykstra2] - constructor which has the base constructor call
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
            //tinfo200:[2021-03-13-tamt2-dykstra2] - nothing in constructor
        }
        //tinfo200:[2021-03-13-tamt2-dykstra2] - series of DbSet objects, each DbSet represents one of the entities
        //tinfo200:[2021-03-13-tamt2-dykstra2] - 3 DbSet entities that tells entity framework to relate to each other
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        //tinfo200:[2021-03-13-tamt2-dykstra2] - method tells entity framework what name for the table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}