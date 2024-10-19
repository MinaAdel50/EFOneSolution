using EFOne.Data;
using EFOne.Entites;

namespace EFOne
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region CRUD Operations

            using ApplicationDbContext dbContext = new ApplicationDbContext();

            #region Instructors

            #region Insert - Creat
            Instructor instructor1 = new Instructor() 
            { Name = "Mariam", Address = "Cairo", Salary = 3000m, Bonus = 100m, HourRate = 50m };
            Instructor instructor2 = new Instructor()
            { Name = "Mohamed", Address = "Alex", Salary = 5000m, Bonus = 200m, HourRate = 80m };
            dbContext.Add(instructor1);
            dbContext.Add(instructor2);
            dbContext.SaveChanges();
            #endregion

            #region Select - Read
            //var myInstructor = (from Instructor in dbContext.Instructors
            //                    where Instructor.Id == 1
            //                    select Instructor).FirstOrDefault();
            var myInstructor = dbContext.Instructors.Where(I => I.Id == 1)
                                                    .FirstOrDefault();


            Console.WriteLine($"Name --> {myInstructor.Name} --- Salary --> {myInstructor.Salary}");


            #endregion

            #region Update
            myInstructor.Name = "Omnia";
            dbContext.SaveChanges();
            Console.WriteLine($"Name --> {myInstructor.Name} --- Salary --> {myInstructor.Salary}");


            #endregion

            #region Delete
            dbContext.Remove(myInstructor);
            dbContext.SaveChanges();
            #endregion


            #endregion

            
            #endregion


        }
    }
}
