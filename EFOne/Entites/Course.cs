using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOne.Entites
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Duration { get; set; }
        public string? Description { get; set; }
        //Take relationship
        public List<StudentCourse> CourseStudents;
        
        //Teach relationship
        public List<InstructorCourse> CoursesInstructors { get; set; } 
    }
}
