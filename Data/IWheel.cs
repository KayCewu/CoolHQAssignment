using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Data
{
    public interface IWheel
    {
        string CreateSecondWheel(string vehicleType);
        string CreateFirstWheel(string vehicleType);
        string CreateThirdWheel(string vehicleType);
        string CreateFourthWheel(string vehicleType);
    }
}
