using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOne.Entites
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public string? Address { get; set; }
        public decimal HourRate { get; set; }
        //Teach relationship
        public List<InstructorCourse>InstructorCourses {  get; set; } 
         
        public int? DepartmentId { get; set; }

    }
}
