// 01. We are given a school. In the school there are classes of students. Each class has a set of teachers. 
// Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique 
// text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. 
// Both teachers and students are people. Students, classes, teachers and disciplines could have optional
// comments (free text block).


// Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate 
// their fields, define the class hierarchy and create a class diagram with Visual Studio.

namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class JustTest
    {
        private static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student("Spinderman", 1),
                new Student("Gubi", 2),
                new Student("Dinko",3),
                new Student("Bat Gergi",4),
                new Student("Toshko",5),
                new Student("Bai Dancho", 6)
            };

            List<Discipline> disciplinesProgramming = new List<Discipline>
            {
                new Discipline("C#-1",20,20),
                new Discipline("C#-2",30,30),
                new Discipline("C#-OOP",40,40)
            };

            List<Discipline> disciplinesDesign = new List<Discipline>
            {
                new Discipline("FEM",20,20),
                new Discipline("Seismic design and assessment",30,30),
                new Discipline("Aboveground storage tanks",40,40)
            };

            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher("Gubi Buklik",disciplinesDesign),
                new Teacher("Pesho Peshev", disciplinesProgramming)
            };

            ClassAtSchool schoolClass = new ClassAtSchool(students, teachers, "12B");

            teachers[0].AddComment("Whatever");
        }
    }
}