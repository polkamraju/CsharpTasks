using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Teacher: Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }
        public void Explain()
        {
            Console.WriteLine("The Teacher is explaining.");
        }
        public override string ToString()
        {
            return "Teacher Name is : " + Name;

        }
    }
}
