using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    class SingleColorLED : Bulb
    {
        private string ColorTemp { get; set; }
        private string TypeOfBulb { get; set; }
        private SingleColorLED()
        {
            Brand = "No name  ";
            TypeOfBulb = "SingleColor";
            OperVolt = "110V";
            PowCons = "10W";
            ColorTemp = "5000K";
        }

        public SingleColorLED(string brand) : this ()
        {
            Brand = brand;
        }

        public override string ToString()
        {
            StringBuilder singleColorLED = new StringBuilder();
            singleColorLED.AppendLine($"TypeOfBulb: {TypeOfBulb}");
            singleColorLED.AppendLine($"Brand: {Brand}");
            singleColorLED.AppendLine($"OperVolt: {OperVolt}");
            singleColorLED.AppendLine($"PowCons: {PowCons}");
            singleColorLED.AppendLine($"ColorTemp: {ColorTemp}");
            return singleColorLED.ToString();
        }
    }
}
