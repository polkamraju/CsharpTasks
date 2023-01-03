using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 integers.");
            int count = 10;
            int[] intArray = new int[count];

            int parsedintValue = 0;

            for (int i = 0; i < count; i++)
            {
                if (int.TryParse(Console.ReadLine(), out parsedintValue))
                {
                    intArray[i] = parsedintValue;
                }
                else
                {
                    Console.WriteLine("Please enter valid integer value.");
                    i--;
                }
            }
            Console.WriteLine("The below are even integers in the given numbers.");

            for (int i = 0; i < count; i++)
            {
                if (intArray[i] % 2 == 0) //printing even numbers
                {
                    Console.WriteLine(intArray[i]);
                }
            }
        }
    }
}
