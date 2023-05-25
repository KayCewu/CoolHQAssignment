using CoolHQAssignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services.Assembly
{
    class AssembleMinibus
    {
        IAssemblyLine minibus = new Minibus();

        public string assembled(string vehicleType)
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            return $"Performing final assembly of {vehicleType}";
        }

        public string[] Assemble(string vehicleType)
        {
            IWheel firstWheel = minibus.CreateWheel();
            IWheel secondWheel = minibus.CreateWheel();
            IWheel thirdWheel = minibus.CreateWheel();
            IWheel fourthWheel = minibus.CreateWheel();
            IChassis carChassis = minibus.CreateChassis();
            ITrim carTrim = minibus.CreateTrim();
            IShell carShell = minibus.CreateShell();

            string sendVehicle = $"Sent {vehicleType} for painting";

            string[] assemblyLine = {
                firstWheel.CreateFirstWheel(vehicleType),
                secondWheel.CreateSecondWheel(vehicleType),
                thirdWheel.CreateThirdWheel(vehicleType),
                fourthWheel.CreateFourthWheel(vehicleType),
                carChassis.VehiclePart(vehicleType),
                carTrim.VehiclePart(vehicleType),
                carShell.VehiclePart(vehicleType),
                assembled(vehicleType),
                sendVehicle,
                "Idle"
            };

            return assemblyLine;
        }
    }
}
