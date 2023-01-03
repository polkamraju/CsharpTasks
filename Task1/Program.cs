using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3  Persons Name");
            Person[] persons = new Person[3];

            try
            {
                for (int i = 0; i < persons.Length; i++)
                {
                    persons[i] = new Person(Convert.ToString(Console.ReadLine()));
                }
                foreach (Person person in persons)
                {
                    Console.WriteLine(person.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                throw;
            }
            Console.Read();
        }
    }
}
