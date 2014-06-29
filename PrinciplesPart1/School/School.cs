namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class School
    {
        private List<ClassAtSchool> schoolClasses;

        public School(List<ClassAtSchool> schoolClasses)
        {
            this.SchoolClasses = new List<ClassAtSchool>(schoolClasses);
        }

        public List<ClassAtSchool> SchoolClasses
        {
            get
            {
                return this.schoolClasses;
            }

            set
            {
                if (this.schoolClasses == null)
                {
                    throw new ArgumentNullException("The list of classes cannot be blank.");
                }

                this.schoolClasses = value;
            }
        }

        public void AddClass(ClassAtSchool schoolClass)
        {
            this.SchoolClasses.Add(schoolClass);
        }

        public void RemoveClass(ClassAtSchool schoolClass)
        {
            this.SchoolClasses.Remove(schoolClass);
        }
    }
}