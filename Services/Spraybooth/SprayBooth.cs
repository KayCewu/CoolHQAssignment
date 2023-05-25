using CoolHQAssignment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services.Spraybooth
{
    // Concrete Factory
    public class WhiteCarBooth: Booth
    {
        public override SprayColor Spray()
        {
            SprayColor color = new WhiteCar();
            return color;
        }
    }

    public class BlackCarBooth: Booth
    {
        public override SprayColor Spray()
        {
            SprayColor color = new BlackCar();
            return color;
        }
    }

    public class WhiteMinibusBooth: Booth
    {
        public override SprayColor Spray()
        {
            SprayColor color = new WhiteMinibus();
            return color;
        }
    }

    public class BlackMinibusBooth: Booth
    {
        public override SprayColor Spray()
        {
            SprayColor color = new BlackMinibus();
            return color;
        }
    }
}
