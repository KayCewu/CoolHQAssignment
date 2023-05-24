using CoolHQAssignment.Data;
using CoolHQAssignment.Services.Assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services.Commands
{
    class BuildMinibusConcreteCommand : ICommandBase
    {
        private Reciever reciever;
        public BuildMinibusConcreteCommand(Reciever r)
        {
            reciever = r;
        }
        public void Execute(string vehicleType)
        {
            reciever.minibusMaker(vehicleType);
        }
    }
}
