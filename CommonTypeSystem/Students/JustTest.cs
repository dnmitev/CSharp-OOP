// 01. Define a class Student, which contains data about a student – first, middle and last name, 
// SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an 
// enumeration for the specialties, universities and faculties. Override the standard methods, 
// inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

// 02. Add implementations of the ICloneable interface. The Clone() method should deeply copy all
// object's fields into a new object of type Student.

// 03. Implement the  IComparable<Student> interface to compare students by names (as first criteria,
// in lexicographic order) and by social security number (as second criteria, in increasing order).

namespace Students
{
    using System;

    public class JustTest
    {
        static void Main()
        {
            Student pesho = new Student("Pesho",
                                        "Peshovski",
                                        "Peshev",
                                        100235689,
                                        "City of Purvomay, Kobilarska Str.,9",
                                        "0889123321",
                                        "peshov@abv.bg",
                                        "third",
                                        Specialty.Chemistry,
                                        University.FMI,
                                        Faculty.NatureScience);

            Console.WriteLine(pesho);

            Student newbie = pesho.Clone();
            Console.WriteLine(newbie);

            pesho.LastName = "Atanasov";
            Console.WriteLine(pesho);
        }
    }
}