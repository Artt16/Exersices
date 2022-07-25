using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    class SingleColorLED : Bulb
    {
        public string ColorTemp { get; set; }
        public readonly string TypeOfBulb;
        public SingleColorLED()
        {
            Brand = "No name  ";
            TypeOfBulb = "SingleColor";
            OperVolt = "110V";
            PowCons = "10W";
            ColorTemp = "5000K";
        }
    }
}
