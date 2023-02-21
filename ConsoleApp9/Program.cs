using System;
using System.Collections.Generic;
using System.Linq;

namespace Bulbs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bulb> list = new List<Bulb>
            {
                new SingleColorLED("Panasonic"),
                new IncandescentLamp("Philips"),
                new MultiColorLED("Sony")
            };

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Full bulb info:");
            for (int i = 0; i < list.Count(); i++)
            {
                ShowBulbInfo.Full(list[i]);
            }
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Common bulb info:");
            ShowBulbInfo.Common(list[1]);
            ShowBulbInfo.Common(list[0]);
            ShowBulbInfo.Common(list[2]);
        }
    }
}
