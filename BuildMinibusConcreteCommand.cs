using CoolHQAssignment.Data;
using CoolHQAssignment.Services.Assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment
{
    class BuildMinibusConcreteCommand : ICommandBase
    {
        private AssembleMinibus _assembleMini;
        public BuildMinibusConcreteCommand(AssembleMinibus assembleMini)
        {
            _assembleMini = assembleMini;
        }
        public void Execute()
        {
            _assembleMini.Assemble();
        }
    }
}
