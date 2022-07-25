using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    class SingleColorLED : Bulb
    {
        public string colorTemp { get; set; }
        public readonly string typeOfBulb;
        public SingleColorLED(string _brand, string _operVolt, string _powCons, string _colorTemp)
        {
            Brand = _brand;
            typeOfBulb = "SingleColor";
            OperVolt = _operVolt;
            PowCons = _powCons;
            colorTemp = _colorTemp;
        }
        public SingleColorLED()
        {
            Brand = "No name  ";
            typeOfBulb = "SingleColor";
            OperVolt = "110V";
            PowCons = "10W";
            colorTemp = "5000K";
        }
    }
}
