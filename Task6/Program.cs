using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid Integer Value.");
           int parsedintValue = 0;
           string number = Console.ReadLine();
            try
            {
                bool parseSuccessful = IsNumber(number, parsedintValue);
                if (parseSuccessful)
                {
                    Console.WriteLine("{0} is a valid Integer.", number);
                }
                else
                {
                    Console.WriteLine("{0} is not an valid Integer.", number);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static bool IsNumber(string number, int parsedintValue)
        {
            if (int.TryParse(number, out parsedintValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
