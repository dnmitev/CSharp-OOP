namespace Animals
{
    using System;
    using System.Linq;

    internal class Tomcat : Cat
    {
        public Tomcat(string name, int age)
        {
            this.Name = name;
            this.Sex = "male";
            this.Age = age;
        }
    }
}