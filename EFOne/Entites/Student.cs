using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOne.Entites
{
    public class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public  string LName { get; set; }
        public string? Address { get; set; }
        public int? Age { get; set; }

        //Take relationship

        public List<StudentCourse> StudentCourses;
        //Located relationship
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
