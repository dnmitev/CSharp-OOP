// 6. Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
// Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace IntArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntArray
    {
        public static void Main()
        {
            List<int> array = new List<int>() { 1, 3, 7, 14, 18, 21, 63, 84, 100 };

            // lambda expression 
            var targetValues = array.FindAll(num => (num % 3 == 0) && (num % 7 == 0));

            Console.WriteLine("Lambda expression: " + string.Join(", ", targetValues));

            // LINQ 
            var targetValuesLinq =
                                  from number in array
                                  where number % 3 == 0 && number % 7 == 0
                                  select number;

            Console.WriteLine("LINQ " + string.Join(", ", targetValuesLinq));
        }
    }
}