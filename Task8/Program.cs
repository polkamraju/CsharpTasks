using System;
using System.Collections;
namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
          

            int peopleCount = 3, age = 0, counter = 0;
            string name = string.Empty;
            ArrayList personArrayList = new ArrayList();
            string[] personOrder = new string[3] {"First","Second","Third"}; 
            Console.WriteLine("Please enter three persons Name and Age details.");
            for (int i = 0; i < peopleCount; i++)
            {
                Console.WriteLine("Enter {0} person Name: ", personOrder[i]);
                name = Console.ReadLine();
                Console.Write("Enter {0}  person Age: ", personOrder[i]);
                age = int.Parse(Console.ReadLine());

                personArrayList.Add(new Person {Name = name, Age = age});
            }

            foreach (Person person in personArrayList)
            {
                Console.WriteLine(String.Format($"\n {personOrder[counter]} Person Name is {person.Name}  and Age is {person.Age}"));
                counter++;
            }

            Console.ReadLine();
        }
    }
}
