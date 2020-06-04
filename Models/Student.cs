using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Registrar.Models
{

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<CourseStudent> Courses { get; }
        

        [NotMapped]
        public string Name =>$"{FirstName} {LastName}";

        public Student()
        {
            this.Courses = new HashSet<CourseStudent>();
        }
    }
}