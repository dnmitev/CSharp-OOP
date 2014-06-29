// 18. Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.
// 19. Rewrite the previous using extension methods.

namespace StudentsExtraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Test
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Vankata", "C#"),
                new Student("Spinderman","HTML"),
                new Student("Pesho","C#"),
                new Student("Gubi","Java"),
                new Student("Getzata","C#")
            };

            // using LINQ
            Console.WriteLine("Task 18:");
            var studentsByGroupName =
                                    from student in students
                                    orderby student.GroupName
                                    select student;

            foreach (var st in studentsByGroupName)
            {
                Console.WriteLine(st);
            }

            // using extension methods
            Console.WriteLine("Task 19:");
            var studentWithExtMethod = students.OrderByGroupName();

            foreach (var st in studentWithExtMethod)
            {
                Console.WriteLine(st);
            }
        }
    }
}
