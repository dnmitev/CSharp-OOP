// 11. Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations 
// and methods and holds a version in the format major.minor (e.g. 2.11). Apply the version attribute to
// a sample class and display its version at runtime.

namespace Attributes
{
    using System;

    [VersionAttribute(2, 1)]
    public class Test
    {
        private static void Main()
        {
            Type type = typeof(Test);
            object[] versionAttributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in versionAttributes)
            {
                Console.WriteLine("Version: {0}.{1}", attribute.Major, attribute.Minor);
            }
        }
    }
}