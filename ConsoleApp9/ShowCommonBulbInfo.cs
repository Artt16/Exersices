using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    // NOTE: Название класса должно передавать сущность, а не действие.
    class ShowCommonBulbInfo
    {
        // NOTE: Нет смысла дублировать название класса в названии метода,
        // т.к. к методу можно обратиться только через объект класса,
        // а значит и так понятно, чем именно метод.
        public static void ShowCommonInfo(ListOfBulbs listOfBulbs)
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

        // NOTE: Ещё один хаб-класс: для каждого нового типа ламп нужно продублировать тут этот метод.
        // Ситуация усугубляется ещё и тем, то ты не только дублируешь метод, создавая клон его сигнатуры для каждого типа,
        // но так же ещё дублируешь и его содержимое.

        // Хаб-класс тут образуется, потому что ответственность за действия связанные с разными реализациями
        // базового класса ты возложил на один этот класс. Т.о. нарушил принцип Single Responsibility.

        private static void ShowOnDisplay(List<MultiColorLED> multiColorLEDs)
        {
            foreach (var multiColorLED in multiColorLEDs)
            {
                Console.WriteLine(multiColorLED.typeOfBulb + "\t\t"+ multiColorLED.Brand + "\t" + multiColorLED.OperVolt + "\t\t" + multiColorLED.PowCons);
            }
        }

        private static void ShowOnDisplay(List<SingleColorLED> singleColorLEDs)
        {
            foreach (var singleColorLED in singleColorLEDs)
            {
                Console.WriteLine(singleColorLED.typeOfBulb + "\t\t" + singleColorLED.Brand + "\t" + singleColorLED.OperVolt + "\t\t" + singleColorLED.PowCons);
            }
        }

        private static void ShowOnDisplay(List<IncandescentLamp> incandescentLamps)
        {
            foreach (var incandescentLamp in incandescentLamps)
            {
                Console.WriteLine(incandescentLamp.TypeOfBulb + "\t" + incandescentLamp.Brand + "\t" + incandescentLamp.OperVolt + "\t\t" + incandescentLamp.PowCons);
            }
        }
    }
}
