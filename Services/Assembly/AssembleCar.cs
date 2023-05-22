using CoolHQAssignment.Data;
using CoolHQAssignment.Services.CarPartsFactory;
using CoolHQAssignment.Services.MinibusPartsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services.Assembly
{
    public class AssembleCar
    {
        IAssemblyLine car = new Car();

        public void Assemble()
        {
            IWheel carWheel = car.CreateWheel();
            IChassis carChasis = car.CreateChassis();
            ITrim carTrim = car.CreateTrim();
            IShell carShell = car.CreateShell();
        }
    }
}
