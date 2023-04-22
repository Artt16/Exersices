using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    class MultiColorLED : Bulb
    {
        private List<string> _colorSet;
        private string _typeOfBulb;

        private MultiColorLED()
        {
            Brand = "No name";
            _typeOfBulb = "MultiColorLED";
            OperationVoltage = 110;
            PowerConsumption = 12;
            _colorSet = new List<string> { "White", "Blue", "Green", "Yelow" };
        }

        public MultiColorLED(string brand) : this()
        {
            Brand = brand;  
        }

        public override string IndividualInfo()
        {
            StringBuilder multiColorLED = new StringBuilder();
            multiColorLED.AppendLine($"TypeOfBulb: {_typeOfBulb}");
            multiColorLED.AppendLine($"ColorSet: {string.Join(',', _colorSet)}");
            return base.ToString() + multiColorLED.ToString();
        }
    }
}
