using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulbs
{
    static class BulbInfoOutput
    {
        public static string ShowFullInfo(Bulb bulb)
        {
            if (bulb == null)
            {
                throw new ArgumentNullException("Bulb is null!");
            }
                
            return bulb.IndividualInfo();
        }

        public static string ShowCommonInfo(Bulb bulb)
        {

            if (bulb == null)
            {
                throw new ArgumentNullException("Bulb is null!");
            }

            return bulb.ToString();         
        }       
    }
}
