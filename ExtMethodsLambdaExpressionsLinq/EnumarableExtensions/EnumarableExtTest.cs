// 2. Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
// sum, product, min, max, average.

namespace EnumarableExtensions
{
    using System;
    using System.Collections.Generic;

    internal class EnumarableExtTest
    {
        private static void Main()
        {
            try
            {
                List<int> test = new List<int>();

                // add some values to the collection
                test.Add(2);
                test.Add(7);
                test.Add(4);
                test.Add(6);
                test.Add(-3);

                // find out the collection sum
                int sum = test.Sum();
                Console.WriteLine(string.Format("Sum: {0}", sum));

                //find out collection product
                int product = test.Product();
                Console.WriteLine(string.Format("Product: {0}", product));

                // find out min element in collection
                int min = test.Min();
                Console.WriteLine(string.Format("Min: {0}", min));

                // find out max element in collection
                int max = test.Max();
                Console.WriteLine(string.Format("Max: {0}", max));

                // find out average
                double averaga = test.Average();
                Console.WriteLine(string.Format("Average: {0}", averaga));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}