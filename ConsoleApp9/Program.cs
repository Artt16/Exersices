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
            
            Console.WriteLine("Full bulb info:\n");
            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(BulbInfoOutput.ShowFullInfo(list[i]));
            }

            
            Console.WriteLine("\nCommon bulb info:\n");
            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(BulbInfoOutput.ShowCommonInfo(list[i]));
            }
        }
    }
}
