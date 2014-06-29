namespace Space3D
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class PathStorage
    {
        private static StreamReader input = new StreamReader(@"..\..\InputCoords.txt");
        private static StreamWriter output = new StreamWriter(@"..\..\OutputCoords.txt");

        public static Path LoadFromFile()
        {
            Path currentPath = new Path();

            using (input)
            {
                string line = input.ReadLine();

                while (line != null)
                {
                    string[] coordinates = line.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    Point3D currentPoint = new Point3D()
                    {
                        X = double.Parse(coordinates[0]),
                        Y = double.Parse(coordinates[1]),
                        Z = double.Parse(coordinates[2])
                    };

                    currentPath.AddPoint(currentPoint);

                    line = input.ReadLine();
                }
            }

            return currentPath;
        }

        public static void SaveToFile(Path current)
        {
            using (output)
            {
                foreach (var path in current.PathList)
                {
                    string result = string.Format("{0}; {1}; {2}", path.X, path.Y, path.Z);
                    output.WriteLine(result);
                }
            }
        }
    }
}
