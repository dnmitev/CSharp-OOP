namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Kitten : Cat
    {
        public Kitten(string name, int age)
        {
            this.Name = name;
            this.Sex = "female";
            this.Age = age;
        }
    }
}
