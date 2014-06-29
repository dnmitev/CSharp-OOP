namespace School
{
    using System;
    using System.Collections.Generic;

    public class ClassAtSchool : ICommentable
    {
        private readonly List<string> comments;

        public ClassAtSchool(List<Student> students, List<Teacher> teachers, string classId)
        {
            this.Students = new List<Student>(students);
            this.Teachers = new List<Teacher>(teachers);
            this.ClassId = classId;
            this.comments = new List<string>();
        }

        public string ClassId { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<Student> Students { get; set; }

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
        }

        public void AddComment(string commentary)
        {
            this.Comments.Add(commentary);
        }

        public void AddStudent(Student st)
        {
            this.Students.Add(st);
        }

        public void RemoveStudent(Student st)
        {
            this.Students.Remove(st);
        }

        public void AddTeacher(Teacher tutor)
        {
            this.Teachers.Add(tutor);
        }

        public void RemoveTeacher(Teacher tutor)
        {
            this.Teachers.Remove(tutor);
        }
    }
}