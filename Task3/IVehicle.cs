using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    interface IVehicle
    {
        void Drive();
        bool Refuel(int gasolineAmount);
    }
}
