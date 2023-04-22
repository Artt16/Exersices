using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    public abstract class Bulb
    {
        protected string Brand { get; set; }
        protected string OperVolt { get; set; }
        protected string PowCons { get; set; }        
    }
}
