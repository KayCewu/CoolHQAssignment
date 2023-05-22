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
            return "Car Shell";
        }
    }
}
