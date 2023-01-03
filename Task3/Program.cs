using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int gasOlineAmount = 0;
            try
            {
                Car car = new Car(gasOlineAmount);
                Console.WriteLine("Please enter gasoline amount in number of litres, you want to refuel your Car.");
                int amount = 0;
                bool parseSuccess = int.TryParse(Console.ReadLine(), out amount);
                if (parseSuccess)
                {
                    gasOlineAmount = amount;
                }
                else
                {
                    Console.WriteLine("Please enter valid value of gasoline in litres in number to refuel your Car.");
                }
                car.Refuel(gasOlineAmount);
                car.Drive();
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                throw;
            }
        }
    }
}
