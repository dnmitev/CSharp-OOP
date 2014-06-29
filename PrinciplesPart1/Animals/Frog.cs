namespace Animals
{
    using System;
    using System.Linq;

    public class Frog : Animal
    {
        public Frog(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Croak-croak!");
        }
    }
}