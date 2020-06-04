using System.Collections.Generic;

namespace Registrar.Models
{
    public class Department
    {
        //Department. Contains [Courses]
        public int DepartmentId { get; set; }
        public string Name{get;set;}
        public string Descriptions{get;set;}
        public string Identifier { get; set;}
        public virtual ICollection<Course> Courses { get; set; }
        public Department()
        {
            this.Courses = new HashSet<Course>();
        }

    }

}