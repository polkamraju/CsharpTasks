using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Car : IVehicle
    {
        public int GasolineAmount { get; private set; }
        public Car(int gasolineAmount)
        {
            GasolineAmount = gasolineAmount;
        }

        public void Drive()
        {
            if (GasolineAmount > 0)
            {
                Console.WriteLine("Car is driving. ");
            }
        }

        public bool Refuel(int gasolineAmount)
        {
            GasolineAmount += gasolineAmount;

            return true;
        }
    }
}
