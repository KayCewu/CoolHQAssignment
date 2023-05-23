using CoolHQAssignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services.CarPartsFactory
{
    class CarWheel : IWheel
    {
        public string VehiclePart()
        {
            Thread.Sleep(TimeSpan.FromSeconds(0.5));
            return "Car Wheel";
        }
    }
}
