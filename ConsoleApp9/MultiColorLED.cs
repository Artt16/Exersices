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
        public readonly string typeOfBulb;

        public MultiColorLED(string _brand, string _operVolt, string _powCons, List<string> _colorSet)
        {
            Brand = _brand;
            typeOfBulb = "MultiColorLED";
            OperVolt = _operVolt;
            PowCons = _powCons;
            ColorSet = _colorSet;
        }
        public MultiColorLED()
        {
            Brand = "No name  ";
            typeOfBulb = "MultiColorLED";
            OperVolt = "110V";
            PowCons = "12W";
            ColorSet = new List<string> { "White", "Blue", "Green", "Yelow" };
        }
    }
}
