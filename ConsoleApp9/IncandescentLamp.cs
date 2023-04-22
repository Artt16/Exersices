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
            OperationVoltage = "110V";
            PowerConsumption = "100W";
            ColorTemperature = "3500K";
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
            incandescentLamb.AppendLine($"Operation voltage: {OperationVoltage}");
            incandescentLamb.AppendLine($"Power consumption: {PowerConsumption}");
            incandescentLamb.AppendLine($"Color temperature: {ColorTemperature}");
            return incandescentLamb.ToString();
        }
    }
}
