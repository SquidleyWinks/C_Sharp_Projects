using System.Data.Entity;

namespace FinalChallengeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Bob" };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}