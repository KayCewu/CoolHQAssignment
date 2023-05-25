using CoolHQAssignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Data.Minibus
{
    class MinibusShell : IShell
    {
        public string VehiclePart(string vehicleType)
        {
           // Thread.Sleep(TimeSpan.FromSeconds(2));
            return $"Creating {vehicleType} Shell";
        }
    }
}
