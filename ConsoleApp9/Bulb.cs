using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    public abstract class Bulb
    {
        private protected string Brand { get; set; }
        private protected string OperVolt { get; set; }
        private protected string PowCons { get; set; }        
    }
}
