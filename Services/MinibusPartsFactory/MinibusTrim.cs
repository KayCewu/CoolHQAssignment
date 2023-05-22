using CoolHQAssignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services.MinibusPartsFactory
{
    class MinibusTrim : ITrim
    {
        public string VehiclePart()
        {
            return "Minibus Trim";
        }
    }
}
