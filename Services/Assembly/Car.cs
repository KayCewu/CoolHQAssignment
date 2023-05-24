using System.Threading;
using CoolHQAssignment.Data;
using CoolHQAssignment.Data.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services.Assembly
{
    class Car : IAssemblyLine
    {
        public IChassis CreateChassis()
        {
            return new CarChassis();
        }

        public IWheel CreateWheel()
        {
            return new CarWheel();
        }

        public ITrim CreateTrim()
        {
            return new CarTrim();
        }

        public IShell CreateShell()
        {
            return new CarShell();
        }
    }
}
