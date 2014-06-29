// 4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

namespace StudentsByAge
{
    using System;
    using System.Linq;

    public class StudentsByAge
    {
        private static void Main()
        {
            // using an anonymous variable to store the students instead of creating a new class
            var students = new[]
            {
                new { FirstName = "Zloben", LastName = "Tigur", Age = 20 },
                new { FirstName = "Bai", LastName = "Georgi", Age = 40 },
                new { FirstName = "Pesho", LastName = "Peshev", Age = 17 },
                new { FirstName = "Unifri", LastName = "Pichagov", Age = 22 },
                new { FirstName = "Toshko", LastName = "Afrikanski", Age = 24 },
                new { FirstName = "Spinderman", LastName = "Spinderov", Age = 19 },
                new { FirstName = "Gubi", LastName = "Buklik", Age = 17 },
            };

            // query
            var queryStudents =
                               from student in students
                               where student.Age >= 18 && student.Age <= 24
                               select student;

            // print the query on the console
            foreach (var st in queryStudents)
            {
                Console.WriteLine("{0} {1}, Age: {2}", st.FirstName, st.LastName, st.Age);
            }
        }
    }
}