using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    public abstract class Bulb
    {
        public string Brand { get; set; }
        public int OperationVoltage { get; set; }
        public int PowerConsumption { get; set; }
        public abstract string IndividualInfo();
        public override string ToString()
        {
            StringBuilder bulb = new StringBuilder();
            bulb.AppendLine($"Brand: {Brand}");
            bulb.AppendLine($"Operation voltage: {OperationVoltage}");
            bulb.AppendLine($"Power consumption: {PowerConsumption}");
            return bulb.ToString();
        }
    }
}
