﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    class IncandescentLamp : Bulb
    {
        public string colorTemp { get; set; }
        public readonly string typeOfBulb;
        public IncandescentLamp(string _operVolt, string _powCons, string _colorTemp)
        {
            typeOfBulb = "IncandescentLamp";
            operVolt = _operVolt;
            powCons = _powCons;
            colorTemp = _colorTemp;
        }
        public IncandescentLamp()
        {
            typeOfBulb = "IncandescentLamp";
            operVolt = "110V";
            powCons = "10W";
            colorTemp = "3500K";
        }
    }
}
