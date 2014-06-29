// 02. Define abstract class Human with first name and last name. Define new class Student which is derived 
// from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary 
// and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the
// proper constructors and properties for this hierarchy. Initialize a list of 10 students and sort them by 
// grade in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and
// sort them by money per hour in descending order. Merge the lists and sort them by first name and last name.

namespace People
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class JustTest
    {
        private static void Main()
        {
            // processing the students
            List<Student> students = new List<Student>
            {
                new Student("Dinko","Biloba",2.5),
                new Student("Bat","Gergii",3.5),
                new Student("Toshko","Afrikanski",3.75),
                new Student("Dzvero","Strashen",4.25),
                new Student("Pesho","Peshev",5.5),
                new Student("Gosho","Peshev",5.27),
                new Student("Spindi","Spinderov",5.92),
                new Student("Gubi","Buklik",5.31),
                new Student("Bai","Dancho",3.17),
                new Student("Bate","Joro",2.09),
            };

            var studentsByGrade =
                                 from student in students
                                 orderby student.Grade
                                 select student;

            foreach (var st in studentsByGrade)
            {
                Console.WriteLine(string.Format("{0}\n", st));
            }

            // processing the workers
            Console.WriteLine("\n\n\n");

            List<Worker> workers = new List<Worker> 
            {
                new Worker("Bai","Ivan",200m,8),
                new Worker("Bai","Stamat",238m,8),
                new Worker("Bai","Tanas",150m,6),
                new Worker("Bat","Man",500m,10),
                new Worker("Vankata","Ivanov",340m,4),
                new Worker("Zloben","Tigur",1000m,12),
                new Worker("Pchelichkata","Maya",500m,14),
                new Worker("Bai","Georgi",120m,3),
                new Worker("Boss","Bossov",1200m,8),
                new Worker("Kaka","Danche",180m,4)
            };

            var workersByHourSallary =
                                      from worker in workers
                                      orderby worker.MoneyPerHour() descending
                                      select worker;

            foreach (var w in workersByHourSallary)
            {
                Console.WriteLine(string.Format("{0}\n", w));
            }

            // merging the workers and students into list of Humans
            Console.WriteLine("\n\n\n");

            var merged = students.Concat<Human>(workers);

            var mergedAndSorted =
                                 from human in merged
                                 orderby human.FirstName, human.LastName
                                 select human;

            foreach (var human in mergedAndSorted)
            {
                Console.WriteLine(human);
            }
        }
    }
}