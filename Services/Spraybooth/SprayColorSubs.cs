using CoolHQAssignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services.Spraybooth
{
    // Concrete Product
    class WhiteCar: SprayColor
    {
        public override string OutputColor()
        {
            return "Spraying White LUX 1000";
        }
    }

    class BlackCar: SprayColor
    {
        public override string OutputColor()
        {
            return "Spraying Black LUX 1000";
        }
    }

    class WhiteMinibus: SprayColor
    {
        public override string OutputColor()
        {
            return "Spraying White MV500";
        }
    }
    class BlackMinibus: SprayColor
    {
        public override string OutputColor()
        {
            return "Spraying Black MV500";
        }
    }
}
