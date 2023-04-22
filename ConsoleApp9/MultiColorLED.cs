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
            OperationVoltage = 110;
            PowerConsumption = 12;
            ColorSet = new List<string> { "White", "Blue", "Green", "Yelow" };
        }

        public MultiColorLED(string brand) : this()
        {
            Brand = brand;  
        }

        public override string IndividualInfo()
        {
            StringBuilder multiColorLED = new StringBuilder();
            multiColorLED.AppendLine($"TypeOfBulb: {TypeOfBulb}");
            multiColorLED.AppendLine($"ColorSet: {string.Join(',', ColorSet)}");
            return base.ToString() + multiColorLED.ToString();
        }
    }
}
