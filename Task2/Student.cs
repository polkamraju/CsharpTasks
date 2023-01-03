using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Student : Person
    {
        public Student(string name): base(name)
        {
            Name = name;
        }
        public void Study()
        {
            Console.WriteLine("The Student is studying");
        }
        public override string ToString()
        {
            return "Student Name is : " + Name;

        }
    }
}
