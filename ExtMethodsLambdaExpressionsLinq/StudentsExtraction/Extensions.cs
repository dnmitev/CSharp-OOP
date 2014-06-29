namespace StudentsExtraction
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static Student[] OrderByGroupName(this IEnumerable<Student> listOfStudents)
        {
            return listOfStudents.OrderBy(x => x.GroupName).ToArray();
        }
    }
}
