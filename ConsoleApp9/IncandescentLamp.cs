using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    public class IncandescentLamp : Bulb
    {
        private string _colorTemperature;
        private string _typeOfBulb;
        private IncandescentLamp()
        {
            Brand = "No name";
            _typeOfBulb = "IncandescentLamp";
            OperationVoltage = 110;
            PowerConsumption = 100;
            _colorTemperature = "3500K";
        }

        public IncandescentLamp(string brand) : this ()
        {           
            Brand = brand;
        }
        public override string IndividualInfo() 
        {
            StringBuilder incandescentLamb = new StringBuilder();
            incandescentLamb.AppendLine($"TypeOfBulb: {_typeOfBulb}");
            incandescentLamb.AppendLine($"Color temperature: {_colorTemperature}");
            return base.ToString() + incandescentLamb.ToString();
        }
    }
}
