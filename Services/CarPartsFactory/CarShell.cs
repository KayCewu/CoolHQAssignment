using CoolHQAssignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services.CarPartsFactory
{
    class CarShell : IShell
    {
        public string VehiclePart()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            return "Car Shell";
        }
    }
}
