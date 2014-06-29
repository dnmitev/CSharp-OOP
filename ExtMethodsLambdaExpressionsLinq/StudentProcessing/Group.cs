// 16. * Create a class Group with properties GroupNumber and DepartmentName. Introduce a property 
// Group in the Student class. Extract all students from "Mathematics" department. Use the Join operator.

namespace StudentProcessing
{
    using System;

    public class Group
    {
        private int groupNum;
        private string departmentName;


        public Group(int number, string dep)
        {
            this.GroupNum = number;
            this.DapartmentName = dep;
        }

        public string DapartmentName
        {
            get
            { 
                return this.departmentName;
            }

            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Department name cannot be blank.");
                }

                departmentName = value; 
            }
        }


        public int GroupNum
        {
            get
            {
                return this.groupNum;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Group number cannot be negative.");
                }

                this.groupNum = value;
            }
        }

    }
}
