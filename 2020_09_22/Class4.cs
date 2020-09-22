using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_22
{
    interface IMan
    {
        string Name { get; set; }
        void Save();
        void Show();
    }

    interface IPerson : IMan
    {
        int Age { get; set; }
    }

    class Employee : IPerson
    {
        int age;
        string name;

        public int Age { get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name = value; } }

        public void Save()
        {
            Console.WriteLine("Name: "+this.name);
        }

        public void Show()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Age: " + this.age);
        }
    }

    class Class4
    {
        static void Main()
        {
            IMan man = new Employee();
         
        }
    }
}
