using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    // NOTE: Каждый раз, когда тебе понадобится добавить новый тип поддерживаемых ламп в этот список,
    // ты будешь вынужден скопипастить Add для нового типа и добавить ещё одно публичное свойство для получения доступа
    // к списку ламп этого нового типа.
    // Во-первых это приводит к образованию т.н. hub класса и его разрастанию,
    // во-вторых, к дублированию кода.

    // NOTE: Какой смысл делать отдельную коллекцию для каждого типа ламп?
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
