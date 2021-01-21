using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Modify and return the given Dictionary as follows: if "Peter" has more than 0 money, transfer half of it to "Paul",
         * but only if Paul has less than $10s.
         *
         * Note, monetary amounts are specified in cents: penny=1, nickel=5, ... $1=100, ... $10=1000, ...
         *
         * RobPeterToPayPaul({"Peter": 2000,   {"Peter": 1000,
         *                    "Paul": 99}) →     "Paul": 1099}
         * RobPeterToPayPaul({"Peter": 2000, "Paul": 30000}) → {"Peter": 2000, "Paul": 30000}
         *
         */
        public Dictionary<string, int> RobPeterToPayPaul(Dictionary<string, int> peterPaul)
        {
            // if the value at Paul is more then 100 then return same dictionary (don't do any thing)
             if (peterPaul["Paul"]>100)
            {
                return peterPaul;
            }
            // if the value at paul is less then 100 then return  
            // for Key Peter value/2 and 
            // for Key.Paul= Paul.Value + (Peter.value/2)
            int robbedMoney = peterPaul["Peter"] / 2;
            
            if (peterPaul["Paul"]<100)
            {
                peterPaul["Paul"] += robbedMoney;
                peterPaul["Peter"] -= robbedMoney;
            }
            return peterPaul;

        }
    }
}
