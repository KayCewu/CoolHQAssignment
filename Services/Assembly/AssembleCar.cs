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
            firstWheel.VehiclePart();
            IWheel secondWheel = car.CreateWheel();
            secondWheel.VehiclePart();
            IWheel thirdWheel = car.CreateWheel();
            thirdWheel.VehiclePart();
            IWheel fourthWheel = car.CreateWheel();
            fourthWheel.VehiclePart();
            IChassis carChassis = car.CreateChassis();
            carChassis.VehiclePart();
            ITrim carTrim = car.CreateTrim();
            carTrim.VehiclePart();
            IShell carShell = car.CreateShell();
            carShell.VehiclePart();
        }

        
    }
}
