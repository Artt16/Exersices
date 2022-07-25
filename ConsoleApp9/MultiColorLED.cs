using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    class MultiColorLED : Bulb
    {
        public List<string> ColorSet { get; set; }
        public readonly string TypeOfBulb;

        public MultiColorLED()
        {
            Brand = "No name  ";
            TypeOfBulb = "MultiColorLED";
            OperVolt = "110V";
            PowCons = "12W";
            ColorSet = new List<string> { "White", "Blue", "Green", "Yelow" };
        }
    }
}
