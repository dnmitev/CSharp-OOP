namespace StringBuilderSubString
{
    using System;
    using System.Text;

    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder input, int startIndex, int length)
        {
            // check if the start index is not out of range
            if (startIndex < 0 || startIndex >= input.Length || startIndex + length >= input.Length)
            {
                throw new IndexOutOfRangeException("Index in method is out of range.");
            }

            // create a new StringBuilder to store the substring and return it
            StringBuilder result = new StringBuilder();

            for (int i = startIndex; i < startIndex + length; i++)
            {
                result.Append(input[i]);
            }

            return result;
        }
    }
}