using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    // NOTE: Замечания в этом классе относятся и к другим классам специфических ламп.
    class IncandescentLamp : Bulb
    {
        public string ColorTemp { get; set; }
        public readonly string TypeOfBulb;

        // NOTE: По неймингу: аргументы именуются с использованием стиля lowerCamelCase.

        // Добавлять инициализацию аргументов через конструктор имеет смысл если
        // инициализируемые свойства не имеют публичных сеттеров (set).
        // Они у тебя публичны, и значит могут быть проинициализированы с помощью синтаксиса,
        // который ты уже использоуешь при создании ламп в списке.
        // Пример: new SingleColorLED() {brand = ...
        public IncandescentLamp(string _brand, string _operVolt, string _powCons, string _colorTemp)
        {
            Brand = _brand;
            TypeOfBulb = "IncandescentLamp";
            OperVolt = _operVolt;
            PowCons = _powCons;
            ColorTemp = _colorTemp;
        }

        // NOTE: Конструктор без параметров я бы вообще сделал приватным,
        // чтобы нельзя было создавать лампу с какими-то непонятными параметрами.
        // Какой смысл такой лампы? Какова вероятность, что эти дефолтные параметры
        // совпадут с теми, которые кому-то нужны?
        // И главное: как разработчик использующий этот твой конструктор,
        // догадается, какими именно значениями проинициализируются параметры лампы,
        // создаваемой через этот конструктор?..
        public IncandescentLamp()
        {
            Brand = "No name  ";
            TypeOfBulb = "IncandescentLamp";
            OperVolt = "110V";
            PowCons = "10W";
            ColorTemp = "3500K";
        }
    }
}
