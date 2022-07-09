using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    abstract class Bulb
    {
        // NOTE: Замечание по неймингу (именованию), свойства именуются с использованием стиля CamelCase (PascalCase).
        public string Brand { get; set; }
        public string operVolt { get; set; }
        public string powCons { get; set; }

    }
}
