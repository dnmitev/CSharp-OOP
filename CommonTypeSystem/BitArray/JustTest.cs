// 05. Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> 
// and Equals(…), GetHashCode(), [], == and !=.

namespace BitArray
{
    using System;
    using System.Linq;

    public class JustTest
    {
        private static void Main()
        {
            BitArray64 number = new BitArray64(9999);
            BitArray64 another = new BitArray64(9999099);

            Console.WriteLine("The bits of {0} are:", number.Number);

            foreach (var bit in number)
            {
                Console.Write(string.Format("{0} ", bit));
            }

            Console.WriteLine();

            Console.WriteLine("{0} == {1} -> {2}", number.Number, another.Number, number == another);
            Console.WriteLine("{0} != {1} -> {2}", number.Number, another.Number, number != another);

            Console.WriteLine("3rd bit in {0} is {1}", another.Number, another[2]);
            Console.WriteLine("The bits of {0} are:", another.Number);
            Console.WriteLine(another);
        }
    }
}