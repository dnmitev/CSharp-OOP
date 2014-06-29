namespace EnumarableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> list)
        {
            CheckIfNull(list);

            T sum = (dynamic)0;

            foreach (var item in list)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> list)
        {
            CheckIfNull(list);

            T product = (dynamic)1;

            foreach (var item in list)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> list) where T : IComparable<T>
        {
            CheckIfNull(list);

            T min = list.First();

            foreach (var item in list)
            {
                if (item < (dynamic)min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> list) where T : IComparable<T>
        {
            CheckIfNull(list);

            T max = list.First();

            foreach (var item in list)
            {
                if (item > (dynamic)max)
                {
                    max = item;
                }
            }

            return max;
        }

        public static double Average<T>(this IEnumerable<T> list) where T : IComparable<T>
        {
            CheckIfNull(list);

            T sum = (dynamic)0;

            foreach (var item in list)
            {
                sum += (dynamic)item;
            }

            double average = (dynamic)sum / (double)list.Count();

            return average;
        }

        // since check for null list is done in every extension method
        // a new method to check the condition is written because of the main rule DRY
        private static void CheckIfNull<T>(IEnumerable<T> list)
        {
            if (list.FirstOrDefault() == null)
            {
                throw new ArgumentNullException("There are not any values in the collection.");
            }
        }
    }
}