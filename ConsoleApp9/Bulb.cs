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
        protected int OperationVoltage { get; set; }
        protected string PowerConsumption { get; set; }        
    }
}
