namespace School
{
    using System;
    using System.Collections.Generic;

    public class Student : Person, ICommentable
    {
        private readonly List<string> comments;

        private int uniqueClassNumber;

        public Student(string name, int classNumber)
            : base(name)
        {
            this.UniqueClassNumber = classNumber;
            this.comments = new List<string>(); // should I use the prop Comments instead of the schoolClasses
        }

        public int UniqueClassNumber
        {
            get
            {
                return this.uniqueClassNumber;
            }

            set
            {
                if (this.uniqueClassNumber < 0)
                {
                    throw new ArgumentException("The unique students number cannot be negative.");
                }

                this.uniqueClassNumber = value;
            }
        }

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
    }
}