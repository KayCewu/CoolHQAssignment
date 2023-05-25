using CoolHQAssignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Data.Car
{
    class CarWheel : IWheel
    {
        public string CreateFirstWheel(string vehicleType)
        {
           //Thread.Sleep(TimeSpan.FromSeconds(0.5));
            return $"Creating {vehicleType} Right Front Wheel";
        }

        public string CreateSecondWheel(string vehicleType)
        {
            //Thread.Sleep(TimeSpan.FromSeconds(0.5));
            return $"Creating {vehicleType} Right Back Wheel";
        }

        public string CreateThirdWheel(string vehicleType)
        {
            //Thread.Sleep(TimeSpan.FromSeconds(0.5));
            return $"Creating {vehicleType} Left Back Wheel";
        }

        public string CreateFourthWheel(string vehicleType)
        {
            //Thread.Sleep(TimeSpan.FromSeconds(0.5));
            return $"Creating {vehicleType} Left Front Wheel";
        }
    }
}
