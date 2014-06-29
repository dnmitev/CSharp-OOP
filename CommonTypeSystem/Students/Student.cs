namespace Students
{
    using System;
    using System.Linq;

    public class Student : ICloneable, IComparable<Student>
    {
        // I am encapsulating fields for the name of the student in order to have not a student without name
        private string firstName;
        private string middleName;
        private string lastName;

        public Student(string firstName,
                       string middleName,
                       string lastName,
                       ulong ssn,
                       string permanentAddress,
                       string mobilePhone,
                       string email,
                       string course,
                       Specialty spec,
                       University uni,
                       Faculty department)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SocialSecurityNumber = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.StudentSpecialty = spec;
            this.StudentUniversity = uni;
            this.StudentFaculty = department;
        }

        public ulong SocialSecurityNumber { get; set; }

        public string PermanentAddress { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public string Course { get; set; }

        public Specialty StudentSpecialty { get; set; }

        public University StudentUniversity { get; set; }

        public Faculty StudentFaculty { get; set; }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be blank.");
                }

                this.lastName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Middle name cannot be blank.");
                }

                this.middleName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be blank.");
                }

                this.firstName = value;
            }
        }

        // methods 
        public override bool Equals(object obj)
        {
            Student st = obj as Student;

            if (ReferenceEquals(null, st))
            {
                return false;
            }

            if (ReferenceEquals(this, st))
            {
                return true;
            }

            // I suppose that the SSN is unique for every person and in that manner I can collate students
            return (this.SocialSecurityNumber == st.SocialSecurityNumber);
        }

        // JustCode generated this override, so thank you TelerikAcademy for the license
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + ((this.firstName != null) ? this.firstName.GetHashCode() : 0);
                result = result * 23 + ((this.middleName != null) ? this.middleName.GetHashCode() : 0);
                result = result * 23 + ((this.lastName != null) ? this.lastName.GetHashCode() : 0);
                result = result * 23 + this.SocialSecurityNumber.GetHashCode();
                result = result * 23 + ((this.PermanentAddress != null) ? this.PermanentAddress.GetHashCode() : 0);
                result = result * 23 + ((this.MobilePhone != null) ? this.MobilePhone.GetHashCode() : 0);
                result = result * 23 + ((this.Email != null) ? this.Email.GetHashCode() : 0);
                result = result * 23 + ((this.Course != null) ? this.Course.GetHashCode() : 0);
                result = result * 23 + this.StudentSpecialty.GetHashCode();
                result = result * 23 + this.StudentUniversity.GetHashCode();
                result = result * 23 + this.StudentFaculty.GetHashCode();
                return result;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} {2} \n\tSocial Security Number: {3} \n\tPermanent Address: {4} \n\tMobile Phone: {5} \n\tEmail: {6} \n\tCourse: {7} \n\tSpecialty: {8} \n\tUniversity: {9} \n\tStudentFaculty: {10}",
                this.FirstName, this.MiddleName, this.LastName, this.SocialSecurityNumber, this.PermanentAddress, this.MobilePhone, this.Email, this.Course, this.StudentSpecialty, this.StudentUniversity, this.StudentFaculty);
        }

        public Student Clone()
        {
            return new Student(this.FirstName,
                               this.MiddleName,
                               this.LastName,
                               this.SocialSecurityNumber,
                               this.PermanentAddress,
                               this.MobilePhone,
                               this.Email,
                               this.Course,
                               this.StudentSpecialty,
                               this.StudentUniversity,
                               this.StudentFaculty);
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            if (this.MiddleName != other.MiddleName)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }

            if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }

            if (this.SocialSecurityNumber != other.SocialSecurityNumber)
            {
                return this.SocialSecurityNumber.CompareTo(other.SocialSecurityNumber);
            }

            return 0;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !(Student.Equals(first, second));
        }
    }
}