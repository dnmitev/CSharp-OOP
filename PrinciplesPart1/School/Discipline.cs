namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Discipline : ICommentable
    {
        private readonly List<string> comments;

        private string name;
        private int countOfLectures;
        private int countOfExercises;

        public Discipline(string name, int lecturesCount, int excersisesCount)
        {
            this.Name = name;
            this.CountOfLectures = lecturesCount;
            this.CountOfExcersises = excersisesCount;
            this.comments = new List<string>(); // should I use the prop Comments instead of the schoolClasses
        }

        public int CountOfExcersises
        {
            get
            {
                return this.countOfExercises;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Exercises count cannot be less than 0.");
                }

                this.countOfExercises = value;
            }
        }

        public int CountOfLectures
        {
            get
            {
                return this.countOfLectures;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Lectures count cannot be less than 0.");
                }

                this.countOfLectures = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Discipline name cannot be left blank.");
                }

                this.name = value;
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