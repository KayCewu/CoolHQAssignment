using CoolHQAssignment.Data;
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

        public string[] Assemble(string vehicleType)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));

            IWheel firstWheel = car.CreateWheel();
            IWheel secondWheel = car.CreateWheel();
            IWheel thirdWheel = car.CreateWheel();
            IWheel fourthWheel = car.CreateWheel();
            IChassis carChassis = car.CreateChassis();
            ITrim carTrim = car.CreateTrim();
            IShell carShell = car.CreateShell();

            string assembled = $"Performing final assembly of {vehicleType}";
            string sendVehicle = $"Sent {vehicleType} for painting";

            string[] assemblyLine = {
                firstWheel.CreateFirstWheel(vehicleType), 
                secondWheel.CreateSecondWheel(vehicleType), 
                thirdWheel.CreateThirdWheel(vehicleType), 
                fourthWheel.CreateFourthWheel(vehicleType), 
                carChassis.VehiclePart(vehicleType), 
                carTrim.VehiclePart(vehicleType), 
                carShell.VehiclePart(vehicleType),
                assembled,
                sendVehicle
            };

            return assemblyLine;
        } 
    }
}
