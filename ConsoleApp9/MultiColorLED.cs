using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    class MultiColorLED : Bulb
    {
        private List<string> ColorSet { get; set; }
        private string TypeOfBulb { get; set; }

        private MultiColorLED()
        {
            Brand = "No name";
            TypeOfBulb = "MultiColorLED";
            OperationVoltage = "110V";
            PowerConsumption = "12W";
            ColorSet = new List<string> { "White", "Blue", "Green", "Yelow" };
        }

        public MultiColorLED(string brand) : this()
        {
            Brand = brand;  
        }

        public override string ToString()
        {
            StringBuilder  multiColorLED = new StringBuilder();
            multiColorLED.AppendLine($"TypeOfBulb: {TypeOfBulb}");
            multiColorLED.AppendLine($"Brand: {Brand}");
            multiColorLED.AppendLine($"Operation voltage: {OperationVoltage}");
            multiColorLED.AppendLine($"Power consumption: {PowerConsumption}");
            multiColorLED.AppendLine($"ColorSet: {string.Join(',', ColorSet)}");
            return multiColorLED.ToString();
        }
    }
}
