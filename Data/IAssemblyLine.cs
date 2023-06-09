﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Data
{
    public interface IAssemblyLine
    {
        IShell CreateShell();

        IChassis CreateChassis();

        IWheel CreateWheel();

        ITrim CreateTrim();
    }
}
