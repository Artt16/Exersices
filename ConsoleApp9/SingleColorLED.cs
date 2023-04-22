using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    class SingleColorLED : Bulb
    {
        private string ColorTemperature { get; set; }
        private string TypeOfBulb { get; set; }
        private SingleColorLED()
        {
            Brand = "No name";
            TypeOfBulb = "SingleColor";
            OperationVoltage = 110;
            PowerConsumption = 10;
            ColorTemperature = "5000K";
        }

        public SingleColorLED(string brand) : this ()
        {
            Brand = brand;
        }

        public override string IndividualInfo()
        {
            StringBuilder singleColorLED = new StringBuilder();
            singleColorLED.AppendLine($"TypeOfBulb: {TypeOfBulb}");
            singleColorLED.AppendLine($"Color temperature: {ColorTemperature}");
            return base.ToString() + singleColorLED.ToString();
        }
    }
}
