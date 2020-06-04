using System.Collections.Generic;

namespace Registrar.Models
{
    public class Course
    {

        public int CourseId { get; set; }
        public int DepartmentId{get;set;}
        public string Name{get;set;}
        public string Descriptions{get;set;}
        public string Identifier { get; set;}
        public virtual ICollection<CourseStudent> Students { get; set; }
        public Course()
        {
            this.Students = new HashSet<CourseStudent>();
        }

    }

}