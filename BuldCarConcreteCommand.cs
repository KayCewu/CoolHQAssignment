using CoolHQAssignment.Data;
using CoolHQAssignment.Services.Assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment
{
    public class BuldCarConcreteCommand : ICommandBase
    {
        private AssembleCar _assembleCar;
        public BuldCarConcreteCommand(AssembleCar assembleCar)
        {
            _assembleCar = assembleCar;
        }
        public void Execute()
        {
            _assembleCar.Assemble();
        }
    }
}
