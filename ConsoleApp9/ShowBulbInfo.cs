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

            var full = bulb.ToString();

            if (full.Contains("ColorTemp"))
            {
                index = full.IndexOf("ColorTemp");
            }

            if (full.Contains("ColorSet"))
            {
                index = full.IndexOf("ColorSet");
            }
            string common = string.Empty;
            common = full[0..index];
            Console.WriteLine(common);            
        }       
    }
}
