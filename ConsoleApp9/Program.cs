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
