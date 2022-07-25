using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    class MultiColorLED : Bulb
    {
        public List<string> colorSet { get; set; }
        public readonly string typeOfBulb;

        public MultiColorLED(string _brand, string _operVolt, string _powCons, List<string> _colorSet)
        {
            Brand = _brand;
            typeOfBulb = "MultiColorLED";
            OperVolt = _operVolt;
            powCons = _powCons;
            colorSet = _colorSet;
        }
        public MultiColorLED()
        {
            Brand = "No name  ";
            typeOfBulb = "MultiColorLED";
            OperVolt = "110V";
            powCons = "12W";
            colorSet = new List<string> { "White", "Blue", "Green", "Yelow" };
        }
    }
}
