namespace School
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person, ICommentable
    {
        private List<Discipline> disciplines;

        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = new List<Discipline>(disciplines);
            this.Comments = new List<string>();
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }

            set
            {
                //if (this.disciplines == null)
                //{
                //    throw new ArgumentNullException("List of disciplines cannot be blank or empty.");
                //}

                this.disciplines = value;
            }
        }

        public List<string> Comments { get; set; }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.Disciplines.Remove(discipline);
        }

        public void ClearSetOfDisciplines()
        {
            this.Disciplines.Clear();
        }

        public void AddComment(string commentary)
        {
            this.Comments.Add(commentary);
        }
    }
}