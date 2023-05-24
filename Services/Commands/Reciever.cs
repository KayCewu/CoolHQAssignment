using CoolHQAssignment.Services.Assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services.Commands
{
    public class Reciever
    {
        public string[] carMaker(string vehicleType)
        {
            string[] assembledProduct;
            AssembleCar car = new AssembleCar();
            if (vehicleType == "Black")
                assembledProduct = car.Assemble(vehicleType);
            else
                assembledProduct = car.Assemble(vehicleType);

            return assembledProduct;
        }

        public string[] minibusMaker(string vehicleType)
        {
            string[] assembledProduct;
            AssembleMinibus minibus = new AssembleMinibus();
            if (vehicleType == "Black")
                assembledProduct = minibus.Assemble(vehicleType);
            else
                assembledProduct = minibus.Assemble(vehicleType);

            return assembledProduct;
        }
    }
}
