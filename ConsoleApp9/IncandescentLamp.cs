using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    public class IncandescentLamp : Bulb
    {
        private string ColorTemp { get; set; }
        private string TypeOfBulb { get; set; }
        private IncandescentLamp()
        {
            Brand = "No name  ";
            TypeOfBulb = "IncandescentLamp";
            OperVolt = "110V";
            PowCons = "100W";
            ColorTemp = "3500K";
        }

        public IncandescentLamp(string brand) : this ()
        {           
            Brand = brand;
        }
        public override string ToString()
        {
            StringBuilder incandescentLamb = new StringBuilder();
            incandescentLamb.AppendLine($"TypeOfBulb: {TypeOfBulb}");
            incandescentLamb.AppendLine($"Brand: {Brand}");
            incandescentLamb.AppendLine($"OperVolt: {OperVolt}");
            incandescentLamb.AppendLine($"PowCons: {PowCons}");
            incandescentLamb.AppendLine($"ColorTemp: {ColorTemp}");
            return incandescentLamb.ToString();
        }
    }
}
