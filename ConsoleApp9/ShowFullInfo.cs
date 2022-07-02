using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    class ShowFullInfo
    {
        public static void Show(MultiColorLED multiColorLED)
        {

            Console.WriteLine(multiColorLED.typeOfBulb + "\t" + multiColorLED.operVolt + "\t" + multiColorLED.powCons + "\t" + string.Join(",", multiColorLED.colorSet));
        }

        public static void Show(SingleColorLED singleColorLED)
        {

            Console.WriteLine(singleColorLED.typeOfBulb + "\t" + singleColorLED.operVolt + "\t" + singleColorLED.powCons + "\t" + singleColorLED.colorTemp);

        }

        public static void Show(IncandescentLamp incandescentLamp)
        {

            Console.WriteLine(incandescentLamp.typeOfBulb + "\t" + incandescentLamp.operVolt + "\t" + incandescentLamp.powCons + "\t" + incandescentLamp.colorTemp);

        }
    }
}
