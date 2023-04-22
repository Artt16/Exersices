using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    static class ShowBulbInfo
    {
        public static void Full(Bulb bulb)
        {
            if (bulb == null)
            {
                throw new ArgumentNullException("Bulb is null!");
            }
                
            Console.WriteLine(bulb.ToString());
        }

        public static void Common(Bulb bulb)
        {
            int index = 0;

            if (bulb == null)
            {
                throw new ArgumentNullException("Bulb is null!");
            }

            var fillInfo = bulb.ToString();

            if (fillInfo.Contains("ColorTemp"))
            {
                index = fillInfo.IndexOf("ColorTemp");
            }

            if (fillInfo.Contains("ColorSet"))
            {
                index = fillInfo.IndexOf("ColorSet");
            }
            string common = string.Empty;
            common = fillInfo[0..index];
            Console.WriteLine(common);            
        }       
    }
}
