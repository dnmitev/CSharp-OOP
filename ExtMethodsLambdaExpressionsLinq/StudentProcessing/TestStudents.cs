namespace StudentProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestStudents
    {
        private static List<Students> students;

        public static void Main()
        {
            students = new List<Students>()
            {
                new Students("Pesho", "Peshev", "115205", "032942211", "pesho@peshkata.com",new List<int> { 4, 5, 6 }, 2),
                new Students("Spindi", "Spinderov", "116206", "0225564455", "spindi@abv.bg",new List<int> { 2, 2, 6 }, 5),
                new Students("Gubi", "Buklik", "122306", "045223366", "gubi_buk@abv.bg",new List<int> { 6, 6, 6 }, 2),
                new Students("Anton", "Brachedev", "115201", "037812358", "tonko@tonkata.com",new List<int> { 3, 6, 5, 6, 3 }, 2),
                new Students("Muhoboiko", "Vmirisov", "111212", "054226532", "mhbk@qmliutichuski.com",new List<int> { 4, 5, 6, 2, 4 }, 1),
                new Students("Gergi", "Jorov", "123512", "07862108", "gergi_yo@mail.bg",new List<int> { 5, 5, 5 }, 3),
                new Students("Spirtian", "Spirtakov", "121505", "02782265", "spiro@spirkata.com",new List<int> { 3, 6, 3, 6, 5 }, 4),
                new Students("Bai", "Ivan", "199902", "032556204", "vankata@facebook.com",new List<int> { 6, 5, 6, 5, 6, 5, 6 }, 1),
                new Students("Chicho", "Dancho", "112300", "029555123", "dancho@gmail.com",new List<int> { 2, 2 }, 3)
            };

            Console.WriteLine("Task 9:");
            FindStudentsFromGroup();

            Console.WriteLine("Task 10:");
            List<Students> studentsFromSpecificGroup = students.GetStudentsFromGroup(2);
            PrintStudents(studentsFromSpecificGroup);

            Console.WriteLine("Task 11:");
            ExtractStudentsWithAbvMail();

            Console.WriteLine("Task 12:");
            ExtractStudentsWithPhoneInSofia();

            Console.WriteLine("Task 13:");
            ExtractExcellentStudents();

            Console.WriteLine("Task 14:");
            var studentsWithPoorMarks = students.GetStudentsWithPoorMarks(2, 2);
            PrintStudents(studentsWithPoorMarks);

            Console.WriteLine("Task 15:");
            GetStudentsMarks();

            Console.WriteLine("Task 16:");
            GetMethematicsDepStudents();
        }

        private static void GetMethematicsDepStudents()
        {
            List<Group> groupByDepartment = new List<Group>()
            {
                new Group(1, "Physics"),
                new Group(2, "Philosophy"),
                new Group(3, "Mathematics"),
                new Group(4, "Civil Engineering"),
                new Group(5, "Medicine")
            };

            var mathStudents =
                                from student in students
                                join gr in groupByDepartment on student.GroupNumber equals gr.GroupNum
                                where gr.DapartmentName == "Mathematics"
                                select student;

            PrintStudents(mathStudents);
        }



        private static void FindStudentsFromGroup()
        {
            // 9.Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName.

            var targetStudents =
                                from student in students
                                where student.GroupNumber == 2
                                orderby student.FirstName
                                select student;

            PrintStudents(targetStudents);
        }

        private static void ExtractStudentsWithAbvMail()
        {
            // 11. Extract all students that have email in abv.bg. Use string methods and LINQ.

            var targetStudents =
                                from student in students
                                where student.Email.EndsWith("abv.bg")
                                select student;

            PrintStudents(targetStudents);
        }

        private static void ExtractStudentsWithPhoneInSofia()
        {
            // 12. Extract all students with phones in Sofia. Use LINQ

            var targetStudents =
                                from student in students
                                where student.Tel.StartsWith("02")
                                select student;

            PrintStudents(targetStudents);
        }

        private static void ExtractExcellentStudents()
        {
            // 13. Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.

            var targetStudents =
                                from student in students
                                where student.Marks.Contains(6)
                                select student;

            PrintStudents(targetStudents);
        }

        private static void GetStudentsMarks()
        {
            // 15.Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 
            // as their 5-th and 6-th digit in the FN).

            var studentMarks =
                                from student in students
                                where student.FacNum.ToString()[4] == '0' && student.FacNum.ToString()[5] == '6'
                                select student.Marks;

            foreach (var item in studentMarks)
            {
                Console.WriteLine("Marks: " + string.Join(", ", item));
            }
        }

        private static void PrintStudents(IEnumerable<Students> students)
        {
            foreach (var st in students)
            {
                Console.WriteLine(st);
            }
        }
    }
}