using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "Name is : " + Name + "\n" + " and Age is : " + Age.ToString() ;
        }

    }
}
