using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Person
    {
        public string Name { get; set; }
        public Person()
        {
        }
        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Name is : " + Name;
        }

        ~Person()
        {
            Name = null;
            Console.WriteLine("Destructor is called");
        }

    }
}
