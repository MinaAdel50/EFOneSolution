using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFOne.Entites
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly HiringDate { get; set; }
        //Located relationship
        public List<Student> Students {  get; set; } 
        
        public List<Instructor> Instructors { get; set; } 
    }
}
