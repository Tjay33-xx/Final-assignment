using System;

namespace CodeFirstStudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                // ensures DB is created
                context.Database.EnsureCreated();

                // add one student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe"
                };

                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }
        }
    }
}
