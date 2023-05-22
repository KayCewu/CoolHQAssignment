using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolHQAssignment.Services
{
    public class Spraybooth
    {
        //Eagerly create instance to ensure we always have one.
        private static Spraybooth instance= new Spraybooth();
        public string CarWhite { get; set; }
        public string CarBlack { get; set; }
        public string MinibusWhite { get; set; }
        public string MinibusBlack { get; set; }
        private Spraybooth()
        {
            CarWhite = "Spraying LUX1000 White";
            CarBlack = "Spraying LUX1000 Black";
            MinibusWhite = "Spraying MV500 White";
            MinibusBlack = "Spraying Bus Black";
        }
        public static Spraybooth getInstance()
        {
            return instance;
        }
    }
}
