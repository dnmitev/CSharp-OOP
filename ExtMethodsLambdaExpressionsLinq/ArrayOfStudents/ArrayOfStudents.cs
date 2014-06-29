// 3. Write a method that from a given array of students finds all students whose first name is before its
// last name alphabetically. Use LINQ query operators.

namespace ArrayOfStudents
{
    using System;
    using System.Linq;

    public class ArrayOfStudents
    {
        private static void Main()
        {
            // use anonymous type to create a new array of students instead of defining a new class
            var students = new[]
            {
                new { FirstName = "Bai", LastName = "Ivan" },
                new { FirstName = "Chicho", LastName = "Asan" },
                new { FirstName = "Bai", LastName = "Georgi" },
                new { FirstName = "Delio", LastName = "Voivoda" },
                new { FirstName = "Zorko", LastName = "Atanasov" },
                new { FirstName = "Ilena", LastName = "Ananasova" },
            };

            // assign query
            var queryStudents =
                               from student in students
                               where student.FirstName.CompareTo(student.LastName) < 0
                               select student;

            // print result on the console
            foreach (var st in queryStudents)
            {
                Console.WriteLine("{0} {1}", st.FirstName, st.LastName);
            }
        }
    }
}