// 04. Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
// Override ToString() to display the information of a person and if age is not specified – to say so. Write a 
// program to test this functionality.

namespace Person
{
    using System;

    public class JustTest
    {
        private static void Main()
        {
            Person pesho = new Person("Pesho");
            Person gosho = new Person("Gergi", 22);

            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
        }
    }
}