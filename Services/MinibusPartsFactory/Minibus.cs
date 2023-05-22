using CoolHQAssignment.Data;
using CoolHQAssignment.MinibusPartsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services.MinibusPartsFactory
{
    class Minibus : IAssemblyLine
    {
        public IChassis CreateChassis()
        {
            return new MinibusChassis();
        }

        public IShell CreateShell()
        {
            return new MinibusShell();
        }

        public IWheel CreateWheel()
        {
            return new MinibusWheel();
        }

        public ITrim CreateTrim()
        {
            return new MinibusTrim();
        }
    }
}
