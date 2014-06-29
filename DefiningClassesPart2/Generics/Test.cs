// 5. Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
// Keep the elements of the list in an array with fixed capacity which is given as parameter in the 
// class constructor. Implement methods for adding element, accessing element by index, removing 
// element by index, inserting element at given position, clearing the list, finding element by its 
// value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.

// 6. Implement auto-grow functionality: when the internal array is full, create a new array of double
// size and move all elements to it.

// 7. Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the
// GenericList<T>. You may need to add a generic constraints for the type T.

namespace Generics
{
    using System;

    internal class Test
    {
        internal static void Main()
        {
            GenericList<int> testList = new GenericList<int>();

            // adding elements to the newly generated list
            testList.AddElement(2);
            testList.AddElement(5);
            testList.AddElement(3);
            testList.AddElement(1);
            testList.AddElement(-17);
            testList.AddElement(35);

            Console.WriteLine(testList);

            // testing the indexator
            Console.WriteLine(testList[1]);
            testList[1] = 12345;
            Console.WriteLine(testList[1]);

            // removing element by index
            testList.RemoveElement(1);
            testList.RemoveElement(2);
            Console.WriteLine("\n" + testList);

            // inserting by index
            testList.InsertElement(1, 212);
            Console.WriteLine(testList);

            // get elements count
            Console.WriteLine("Elements count: {0}", testList.Count());

            // find element
            Console.WriteLine(testList.FindElement(35));
            Console.WriteLine(testList.FindElement(-100));

            // find min element
            Console.WriteLine("Min: {0}", testList.MinElement());

            // find max element
            Console.WriteLine("Max: {0}", testList.MaxElement());

            // clear the list
            testList.Clear();
            Console.WriteLine("\n" + testList);
        }
    }
}
