using System;
using System.Collections.Generic;
using System.Linq;

namespace Bulbs
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ListOfBulbs();
            list.Add(new SingleColorLED() { Brand = "Panasonic", OperVolt = "110V", PowCons = "9W", colorTemp = "6000K" });
            list.Add(new IncandescentLamp() { Brand = "Philips  ", OperVolt = "220V", PowCons = "60W", colorTemp = "3200K" });
            list.Add(new MultiColorLED() { Brand = "Toshiba  ", OperVolt = "110V", PowCons = "15W", colorSet = new List<string>() { "Pink", "Red", "White", "Orange" } });
            list.Add(new SingleColorLED());
            list.Add(new MultiColorLED());
            list.Add(new IncandescentLamp());
            list.Add(new MultiColorLED());
            ShowCommonBulbInfo.ShowCommonInfo(list);
            Console.WriteLine("\n\n\n\n\n");
            ShowFullBulbInfo.ShowFullInfo(list);
        }
    }
}
