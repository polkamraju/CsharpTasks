using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
   public abstract class Animal
    {
        public string Name { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
        public abstract void Eat();
        

    }
}
