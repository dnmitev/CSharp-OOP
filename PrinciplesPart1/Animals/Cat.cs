namespace Animals
{
    using System;
    using System.Linq;

    public class Cat : Animal
    {
        public override void ProduceSound()
        {
            Console.WriteLine("Meow-meow!");
        }
    }
}