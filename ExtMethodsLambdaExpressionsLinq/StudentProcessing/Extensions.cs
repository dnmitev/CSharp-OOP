namespace StudentProcessing
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static List<Students> GetStudentsFromGroup(this List<Students> list, int grNumber)
        {
            // 10. Select only the students that are from group number 2. Use LINQ query. Order the students by FirstName.
            // Implement the previous using the same query expressed with extension methods.

            var targetStudents =
                                 from student in list
                                 where student.GroupNumber == grNumber
                                 orderby student.FirstName
                                 select student;

            return targetStudents.ToList();
        }

        public static List<Students> GetStudentsWithPoorMarks(this List<Students> list, int mark, int number)
        {
            // 14. Write down a similar program that extracts the students with exactly  two marks "2". 
            // Use extension methods.

            var targetStudents =
                                from student in list
                                where student.Marks.Count(x => x == mark) == number
                                select student;

            return targetStudents.ToList();
        }

    }
}