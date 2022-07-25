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

        public MultiColorLED(string _brand, string _operVolt, string _powCons, List<string> _colorSet)
        {
            Brand = _brand;
            TypeOfBulb = "MultiColorLED";
            OperVolt = _operVolt;
            PowCons = _powCons;
            ColorSet = _colorSet;
        }
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
