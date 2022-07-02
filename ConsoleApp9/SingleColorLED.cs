﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    class SingleColorLED : Bulb
    {
        public string colorTemp { get; set; }
        public readonly string typeOfBulb;
        public SingleColorLED(string _operVolt, string _powCons, string _colorTemp)
        {
            typeOfBulb = "SingleColor";
            operVolt = _operVolt;
            powCons = _powCons;
            colorTemp = _colorTemp;
        }
        public SingleColorLED()
        {
            typeOfBulb = "SingleColor";
            operVolt = "110V";
            powCons = "10W";
            colorTemp = "5000K";
        }
    }
}
