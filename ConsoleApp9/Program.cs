using System;
using System.Collections.Generic;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>() { "Type of Bulb: \t\t" + "OperVolt: \t" + "PowCons:  \t" + "ColorTemp:  \t" + "ColorSet:  \t" };
            list.Add(new SingleColorLED() { operVolt = "110V", powCons = "9W", colorTemp = "5500K"});
            list.Add(new IncandescentLamp() { operVolt = "220V", powCons = "60W", colorTemp = "3200K" });
            list.Add(new MultiColorLED() { operVolt = "110V", powCons = "15W", colorSet = new List<string>() { "Pink", "Red", "White", "Orange"} });
            list.Add(new SingleColorLED());
            list.Add(new MultiColorLED());
            list.Add(new IncandescentLamp());
            ShowListOfBulbs(list);
        }

        static void ShowListOfBulbs(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        
    }

    abstract class Bulb
    {
        public string operVolt { get; set; }
        public string powCons { get; set; }

    }

    class MultiColorLED : Bulb
    {        
        public List<string> colorSet { get; set; }

        public MultiColorLED(string _operVolt, string _powCons, List<string> _colorSet)
        {
            operVolt = _operVolt;
            powCons = _powCons;
            colorSet = _colorSet;
        }
        public MultiColorLED()
        {
            operVolt = "110V";
            powCons = "12W";
            colorSet = new List<string>{ "White", "Blue", "Green", "Yelow"};
        }
        private string ConvertToString()
        {
            if (colorSet == null)
            {
                throw new ArgumentException("color set is needed!");
            }
            string _ = string.Empty;
            foreach(var item in colorSet)
            {
                _+= item + ", ";
            }
            return _;
        }

        public static implicit operator string(MultiColorLED bulb) => 
            ("MultiColorLED \t\t" + bulb.operVolt + " \t\t" + bulb.powCons + " \t\t"  + " - \t\t" + bulb.ConvertToString() + " \t");

    }

    class SingleColorLED : Bulb
    {
        public string colorTemp { get; set; }
        public SingleColorLED(string _operVolt, string _powCons, string _colorTemp)
        {
            operVolt = _operVolt;
            powCons = _powCons;
            colorTemp = _colorTemp;
        }
        public SingleColorLED()
        {
            operVolt = "110V";
            powCons = "10W";
            colorTemp = "5000K";
        }
        public static implicit operator string (SingleColorLED bulb) => 
            ("SingleColorLED \t\t" + bulb.operVolt + " \t\t" + bulb.powCons + " \t\t" + bulb.colorTemp + " \t\t" + " - \t");
    }

    class IncandescentLamp : Bulb
    {
        public string colorTemp { get; set; }
        public IncandescentLamp(string _operVolt, string _powCons, string _colorTemp)
        {
            operVolt = _operVolt;
            powCons = _powCons;
            colorTemp = _colorTemp;
        }
        public IncandescentLamp()
        {
            operVolt = "110V";
            powCons = "10W";
            colorTemp = "3500K";
        }
        public static implicit operator string(IncandescentLamp bulb) =>
            ("IncandescentLamp \t" + bulb.operVolt + " \t\t" + bulb.powCons + " \t\t" + bulb.colorTemp + " \t\t" + " - \t");
    }

}
