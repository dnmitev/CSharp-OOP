// 03. Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
// It should hold error message and a range definition [start … end].

// Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by 
// entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

namespace ExceptionClass
{
    using System;
    using System.Globalization;
    using System.Linq;

    public class JustTest
    {
        private static void Main()
        {
            TestWithNumbers();
            TestWithDates();
        }

        private static void TestWithDates()
        {
            CultureInfo culture = CultureInfo.InvariantCulture;

            DateTime start = new DateTime(1980, 1, 1);
            DateTime end = new DateTime(2013, 12, 31);

            Console.Write("Enter a date: ");

            try
            {
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", culture);

                if (date < start || date > end)
                {
                    throw new InvalidRangeException<DateTime>("Entered date is not in the range", start, end);
                }
                else
                {
                    Console.WriteLine("Successfully parsed to DateTime!");
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("{0} [{1:dd.mm.yyyy}; {2:dd.mm.yyyy}]", ex.Message, ex.Start, ex.End);
            }
        }

        private static void TestWithNumbers()
        {
            int start = 1;
            int end = 100;

            Console.Write("Please enter a number: ");

            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number < start || number > end)
                {
                    throw new InvalidRangeException<int>("Entered number is not in the range", start, end);
                }
                else
                {
                    Console.WriteLine("Successfully parsed to int!");
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("{0} [{1}; {2}]", ex.Message, ex.Start, ex.End);
            }
        }
    }
}