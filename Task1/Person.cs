using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Person
    {   
        private string Name { get; set; }
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
            Name = string.Empty;
            Console.WriteLine("Destructor is called");
        }

    }
}
