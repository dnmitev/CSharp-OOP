// 1. Implement an extension method Substring(int index, int length) for the class StringBuilder
// that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace StringBuilderSubString
{
    using System;
    using System.Text;

    public class TestSubString
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("I am some dumb text used in StringBuilder just for the test");

            StringBuilder result = new StringBuilder();
            result = sb.Substring(10, 4); // "dumb" is the expected result

            Console.WriteLine(result);
        }
    }
}