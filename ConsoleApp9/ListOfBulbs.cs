using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    class ListOfBulbs
    {
        public List<SingleColorLED> singleColorLEDs;
        public List<MultiColorLED> multiColorLEDs;
        public List<IncandescentLamp> incandescentLamps;

        public ListOfBulbs()
        {
            singleColorLEDs = new List<SingleColorLED>();
            multiColorLEDs = new List<MultiColorLED>();
            incandescentLamps = new List<IncandescentLamp>();
        }
        public void Add(SingleColorLED singleColorLED)
        {            
            singleColorLEDs.Add(singleColorLED);            
        }

        public void Add(MultiColorLED multiColorLED)
        {
            multiColorLEDs.Add(multiColorLED);            
        }

        public void Add(IncandescentLamp incandescentLamp)
        {
            incandescentLamps.Add(incandescentLamp);            
        }        
    }
}
