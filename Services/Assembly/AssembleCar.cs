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
            Thread.Sleep(TimeSpan.FromSeconds(2));

            IWheel firstWheel = car.CreateWheel();
            IWheel secondWheel = car.CreateWheel();
            IWheel thirdWheel = car.CreateWheel();
            IWheel fourthWheel = car.CreateWheel();
            IChassis carChassis = car.CreateChassis();
            ITrim carTrim = car.CreateTrim();
            IShell carShell = car.CreateShell();
        }
    }
}
