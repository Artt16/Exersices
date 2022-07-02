using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    class ShowFullBulbInfo
    {
        public static void ShowFullInfo(ListOfBulbs listOfBulbs)
        {
            if (listOfBulbs.singleColorLEDs != null)
            {
                ShowOnDisplay(listOfBulbs.singleColorLEDs);
            }

            if (listOfBulbs.multiColorLEDs != null)
            {
                ShowOnDisplay(listOfBulbs.multiColorLEDs);
            }

            if (listOfBulbs.incandescentLamps != null)
            {
                ShowOnDisplay(listOfBulbs.incandescentLamps);
            }
        }

        private static void ShowOnDisplay(List<MultiColorLED> multiColorLEDs)
        {
            foreach (var multiColorLED in multiColorLEDs)
            {
                Console.WriteLine(multiColorLED.typeOfBulb + "\t\t" + multiColorLED.brand + "\t" + multiColorLED.operVolt + "\t\t" + multiColorLED.powCons + "\t\t\t\t" + string.Join(",", multiColorLED.colorSet));
            }
            
        }

        private static void ShowOnDisplay(List<SingleColorLED> singleColorLEDs)
        {
            foreach (var singleColorLED in singleColorLEDs)
            {
                Console.WriteLine(singleColorLED.typeOfBulb + "\t\t" + singleColorLED.brand + "\t" + singleColorLED.operVolt + "\t\t" + singleColorLED.powCons + "\t\t" + singleColorLED.colorTemp);
            }
        }

        private static void ShowOnDisplay(List<IncandescentLamp> incandescentLamps)
        {
            foreach (var incandescentLamp in incandescentLamps)
            {
                Console.WriteLine(incandescentLamp.typeOfBulb + "\t" + incandescentLamp.brand + "\t" + incandescentLamp.operVolt + "\t\t" + incandescentLamp.powCons + "\t\t" + incandescentLamp.colorTemp);
            }
        }
    }
}
