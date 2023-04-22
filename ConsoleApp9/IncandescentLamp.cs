using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    public class IncandescentLamp : Bulb
    {
        private string ColorTemperature { get; set; }
        private string TypeOfBulb { get; set; }
        private IncandescentLamp()
        {
            Brand = "No name";
            TypeOfBulb = "IncandescentLamp";
            OperationVoltage = 110;
            PowerConsumption = 100;
            ColorTemperature = "3500K";
        }

        public IncandescentLamp(string brand) : this ()
        {           
            Brand = brand;
        }
        public override string IndividualInfo() 
        {
            StringBuilder incandescentLamb = new StringBuilder();
            incandescentLamb.AppendLine($"TypeOfBulb: {TypeOfBulb}");
            incandescentLamb.AppendLine($"Color temperature: {ColorTemperature}");
            return base.ToString() + incandescentLamb.ToString();
        }
    }
}
