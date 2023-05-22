using CoolHQAssignment.Data;
using CoolHQAssignment.Services.MinibusPartsFactory;
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

        public void Assemble()
        {
            IWheel minibusWheel = minibus.CreateWheel();
            IShell minibusShell = minibus.CreateShell();
            ITrim minibusTrim = minibus.CreateTrim();
            IChassis minibusChassis = minibus.CreateChassis();
        }
    }
}
