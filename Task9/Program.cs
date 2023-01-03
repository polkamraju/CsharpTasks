using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers which are to be multiplied.");
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            int i = 0;

            while (i < secondNumber)
            {
                result = result + firstNumber;
                i++;
            }
            Console.WriteLine("Below is output");
            Console.WriteLine("{0}x{1}= {2}", firstNumber, secondNumber, result);
        }
    }
}
