using CoolHQAssignment.Data;
using CoolHQAssignment.Services.Assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services.Commands
{
    public class BuldCarConcreteCommand : ICommandBase
    {
        private Reciever reciever;
        public BuldCarConcreteCommand(Reciever r)
        {
            reciever = r;
        }
        public void Execute(string vehicleType)
        {
            reciever.carMaker(vehicleType);
        }
    }
}
