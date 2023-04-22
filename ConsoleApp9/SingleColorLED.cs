using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    class SingleColorLED : Bulb
    {
        private string _colorTemperature;
        private string _typeOfBulb;
        private SingleColorLED()
        {
            Brand = "No name";
            _typeOfBulb = "SingleColor";
            OperationVoltage = 110;
            PowerConsumption = 10;
            _colorTemperature = "5000K";
        }

        public SingleColorLED(string brand) : this ()
        {
            Brand = brand;
        }

        public override string IndividualInfo()
        {
            StringBuilder singleColorLED = new StringBuilder();
            singleColorLED.AppendLine($"TypeOfBulb: {_typeOfBulb}");
            singleColorLED.AppendLine($"Color temperature: {_colorTemperature}");
            return base.ToString() + singleColorLED.ToString();
        }
    }
}
