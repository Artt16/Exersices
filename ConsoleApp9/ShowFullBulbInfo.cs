using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    // NOTE: См. замечания для ShowCommonBulbInfo
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
                Console.WriteLine(multiColorLED.typeOfBulb + "\t\t" + multiColorLED.Brand + "\t" + multiColorLED.OperVolt + "\t\t" + multiColorLED.powCons + "\t\t\t\t" + string.Join(",", multiColorLED.colorSet));
            }
            
        }

        private static void ShowOnDisplay(List<SingleColorLED> singleColorLEDs)
        {
            foreach (var singleColorLED in singleColorLEDs)
            {
                Console.WriteLine(singleColorLED.typeOfBulb + "\t\t" + singleColorLED.Brand + "\t" + singleColorLED.OperVolt + "\t\t" + singleColorLED.powCons + "\t\t" + singleColorLED.colorTemp);
            }
        }

        private static void ShowOnDisplay(List<IncandescentLamp> incandescentLamps)
        {
            foreach (var incandescentLamp in incandescentLamps)
            {
                Console.WriteLine(incandescentLamp.typeOfBulb + "\t" + incandescentLamp.Brand + "\t" + incandescentLamp.OperVolt + "\t\t" + incandescentLamp.powCons + "\t\t" + incandescentLamp.colorTemp);
            }
        }
    }
}
