namespace Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Struct |
                    AttributeTargets.Class |
                    AttributeTargets.Interface |
                    AttributeTargets.Enum |
                    AttributeTargets.Method, AllowMultiple = false)]

    public class VersionAttribute : System.Attribute
    {
        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major { get; private set; }

        public int Minor { get; private set; }
    }
}