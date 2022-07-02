using System;
using System.Collections.Generic;
using System.Linq;

namespace Bulbs
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = new ListOfBulbs();
            //list.Add(new SingleColorLED() { operVolt = "110V", powCons = "9W", colorTemp = "6000K" });
            //list.Add(new IncandescentLamp() { operVolt = "220V", powCons = "60W", colorTemp = "3200K" });
            //list.Add(new MultiColorLED() { operVolt = "110V", powCons = "15W", colorSet = new List<string>() { "Pink", "Red", "White", "Orange" } });
            //list.Add(new SingleColorLED());
            //list.Add(new MultiColorLED());
            //list.Add(new IncandescentLamp());
            //list.Add(new MultiColorLED());
            //list.ShowListOfBulbs();

            var item = new MultiColorLED();
            ShowFullInfo.Show(item);
        }
    }
}
