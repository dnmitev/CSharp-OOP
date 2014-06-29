// 03. Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
// Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
// Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only 
// female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different 
// kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class JustTest
    {
        public static double GetAverageAge(Animal[] animals) // how to do it with list
        {
            double sumOfAges = 0;
            double average = 0;

            foreach (var animal in animals)
            {
                sumOfAges += animal.Age;
            }

            average = sumOfAges / animals.Length;

            return average;
        }

        private static void Main()
        {
            List<Dog> dogs = new List<Dog>
            {
                new Dog("Sharo","male",5),
                new Dog("Balkan","male",1),
                new Dog("Fifi","female",1),
                new Dog("Zvqr","male",3)
            };

            List<Frog> frogs = new List<Frog>
            {
                new Frog("Anastacia","female",10),
                new Frog("Frangilina","female",4),
                new Frog("Frank","male",7),
                new Frog("Robert","male",7)
            };

            List<Cat> cats = new List<Cat>
            {
                new Tomcat("Puhcho",3),
                new Kitten("Tin-tin",1),
                new Kitten("Pantera",4)
            };

            Console.WriteLine("Average cats' age is: {0:F2}", GetAverageAge(cats.ToArray()));
            Console.WriteLine("Average dogs' age is: {0:F2}", GetAverageAge(dogs.ToArray()));
            Console.WriteLine("Average frogs' age is: {0:F2}", GetAverageAge(frogs.ToArray()));

            List<Animal> animalKingdom = new List<Animal>();
            animalKingdom.AddRange(cats);
            animalKingdom.AddRange(frogs);
            foreach (var item in animalKingdom)
            {
                Console.WriteLine(item);
            }
            }
    }
}