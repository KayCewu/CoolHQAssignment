using CoolHQAssignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services.MinibusPartsFactory
{
    class MinibusShell : IShell
    {
        public string VehiclePart()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            return "Minibus Shell";
        }
    }
}
