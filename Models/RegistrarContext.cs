using Microsoft.EntityFrameworkCore;

namespace Registrar.Models
{

    public class RegistrarContext : DbContext
    {
        public virtual DbSet<Department> Departments{get;set;}
        public virtual DbSet<Course> Courses{get;set;}
        public virtual DbSet<Student> Students{get;set;}
        public virtual DbSet<CourseStudent> CourseStudent{get;set;}
        public RegistrarContext(DbContextOptions options) : base(options){   }
        
    }
}