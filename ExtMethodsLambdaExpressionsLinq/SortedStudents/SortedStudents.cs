// 5.Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name 
// and last name in descending order. Rewrite the same with LINQ.

namespace SortedStudents
{
    using System;
    using System.Linq;

    public class SortedStudents
    {
        public static void Main()
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
                new { FirstName = "Spirit", LastName = "Spiritakov", Age = 37 },
            };

            // using lambda expression to sort student
            Console.WriteLine("Using Lambda Expression:");

            var sortedStudents = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

            foreach (var st in sortedStudents)
            {
                Console.WriteLine("{0} {1}, Age: {2}", st.FirstName, st.LastName, st.Age);
            }

            Console.WriteLine();

            // using LINQ to sort students
            Console.WriteLine("Using LINQ:");

            var sortedStudentsLinq =
                                    from student in students
                                    orderby student.FirstName descending, student.LastName descending
                                    select student;

            foreach (var st in sortedStudentsLinq)
            {
                Console.WriteLine("{0} {1}, Age: {2}", st.FirstName, st.LastName, st.Age);
            }

            Console.WriteLine();
        }
    }
}