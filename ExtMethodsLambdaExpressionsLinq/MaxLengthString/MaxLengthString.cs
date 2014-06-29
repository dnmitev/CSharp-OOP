// 17. Write a program to return the string with maximum length from an array of strings. Use LINQ.

namespace MaxLengthString
{
    using System;
    using System.Linq;

    public class MaxLengthString
    {
        public static int longest = 0;

        public static void Main()
        {
            string input = "This stupid sentence will be the array in which I am looking for the longest string.";

            string[] array = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var longestString =
                                from word in array
                                where IsLonger(word)
                                select word;

            Console.WriteLine("Longest string: " + longestString.Last());
        }

        private static bool IsLonger(string word)
        {
            if (word.Length > longest)
            {
                longest = word.Length;
                return true;
            }

            return false;
        }
    }
}
