using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классы_и_объекты
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Raziat = new Person("Разият", 16);
            Raziat.Print();
            Person Viсtor = new Person("Виктор", 16);
            Raziat.Print();
            Person Magomed = new Person("Магомед", 17);
            Magomed.Print();
            Person Abdulhakim = new Person("Абдулхаким", 20);
            Abdulhakim.Print();
            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public byte Age { get; set; }

        public Person(string name, byte age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name} \nAge: {Age}");
        }
    }
}
