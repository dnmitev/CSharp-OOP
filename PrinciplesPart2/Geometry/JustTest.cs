// 01. Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
// Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the 
// figure (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable constructor
// so that at initialization height must be kept equal to width and implement the CalculateSurface() method. Write a
// program that tests the behavior of  the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) 
// stored in an array.

namespace Geometry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class JustTest
    {
        private static void Main()
        {
            var figures = new List<Shape>
            {
                new Circle(2),
                new Rectangle(2.5,4),
                new Triangle(8,1.25)
            };

            foreach (var fig in figures)
            {
                double area = fig.CalculateSurface();

                if (fig is Circle)
                {
                    Console.WriteLine("Circle's area: {0:F2}", area);
                }
                else if (fig is Rectangle)
                {
                    Console.WriteLine("Rectangle's area: {0:F2}", area);
                }
                else
                {
                    Console.WriteLine("Triangle's area: {0:F2}", area);
                }
            }
        }
    }
}