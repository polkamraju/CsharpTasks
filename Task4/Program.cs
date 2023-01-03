using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the name of the Dog.");
            try
            {
                Dog dog = new Dog();
                dog.SetName(Console.ReadLine().ToString());
                Console.WriteLine("The name of the Dog is :" + dog.GetName());
                dog.Eat();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                throw;
            }
        }
    }
}
