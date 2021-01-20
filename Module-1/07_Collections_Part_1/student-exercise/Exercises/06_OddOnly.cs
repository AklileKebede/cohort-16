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
          Given an array of Integers, return a List of Integers containing just the odd values.
          OddOnly( {112, 201, 774, 92, 9, 83, 41872} ) -> [201, 9, 83]
          OddOnly( {1143, 555, 7, 1772, 9953, 643} ) -> [1143, 555, 7, 9953, 643]
          OddOnly( {734, 233, 782, 811, 3, 9999} ) -> [233, 811, 3, 9999]
          */
        public List<int> OddOnly(int[] integerArray)
        {
            // set a new return list
            // create a loop that index%2==1

            List<int> retunList = new List<int>();
            foreach (int integer in integerArray)
            {
                if (integer % 2 == 1)
                {
                    retunList.Add(integer);
                }
            }
            return retunList;
        }
    }
}
