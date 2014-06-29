// 1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidean 3D space. 
// Implement the ToString() to enable printing a 3D point.\

// 2. Add a private static read-only field to hold the start of the coordinate system – the
// point O{0, 0, 0}. Add a static property to return the point O.

// 3. Write a static class with a static method to calculate the distance between two points in the 3D space.

// 4. Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage 
// with static methods to save and load paths from a text file. Use a file format of your choice.

namespace Space3D
{
    using System;

    internal class Test
    {
        static void Main()
        {
            // calculate distance between 2 given points in the space
            Point3D first = new Point3D(2, 3, 5);
            Point3D second = new Point3D(4, 7, 10);

            double distance = Distance.CalculateDistance(first, second);

            Console.WriteLine("The distance between {0} and {1} is {2:F3}",first, second, distance);

            // save path list to external file
            Path newPath = PathStorage.LoadFromFile();

            newPath.AddPoint(first);
            newPath.AddPoint(second);

            foreach (var path in newPath.PathList)
            {
                Console.WriteLine(path);
            }

            PathStorage.SaveToFile(newPath);
        }
    }
}
