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
         * Modify and return the given Dictionary as follows: if "Peter" has $50 or more, AND "Paul" has $100 or more,
         * then create a new "PeterPaulPartnership" worth a combined contribution of a quarter of each partner's
         * current worth.
         *
         * PeterPaulPartnership({"Peter": 50000, →  {"Peter": 37500, 
         *                      "Paul": 100000}) →  "Paul": 75000, 
         *                                          "PeterPaulPartnership": 37500}
         * PeterPaulPartnership({"Peter": 3333, →    {"Peter": 3333, 
         *                     "Paul": 1234567890})→ "Paul": 1234567890}
         */
        public Dictionary<string, int> PeterPaulPartnership(Dictionary<string, int> peterPaul)
        {
            // If Peter>=50000 && Paul>=100000 then keep dictionary
            if (peterPaul["Peter"]< 50000 && peterPaul["Paul"] < 100000)
            {
                return peterPaul;
            }
            // If Peter>=50000 && Paul>=100000 then update dictionary:
            
            int peterContribution = peterPaul["Peter"] / 4;
            int paulContribution = peterPaul["Paul"] / 4;
            // Add a Key-Value-Pair that is the sum of the new values called "PeterPaulPartnership"
            // Keep 0.75*value of Peter  && Paul money
            if (peterPaul["Peter"] >= 50000 && peterPaul["Paul"] >= 100000)
            {
                peterPaul["Peter"] -= peterContribution;
                peterPaul["Paul"] -= paulContribution;
                peterPaul["PeterPaulPartnership"] = peterContribution + paulContribution;
            }
            
           
            return peterPaul;
        }
    }
}
