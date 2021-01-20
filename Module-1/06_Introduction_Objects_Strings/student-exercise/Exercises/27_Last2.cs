using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return the count of the number of times that a substring length 2 appears in the string and
         also as the last 2 chars of the string, so "hixxxhi" yields 1 (we won't count the end substring).
         Last2("hixx|hi") → 1 \\1. found "hi", 2. if the first two char equal to last two add 1 , 3. go to second char and look for "hi" 4. until index=length -2 
         Last2("xaxxaxa|xx") → 1
         Last2("ax(x)xaa|xx") → 2
        ax -->0
        x(x)x--> 1
         */
        public int Last2(string str)
        {
            // Todo: 1. check string length >2
            if (str.Length <= 2)
            {
                return 0;
            }

            string lastTwoChar = str.Substring(str.Length - 2); // identify the last two char as substring to find
            int result = 0;
            
            for (int i=0; i < str.Length-2; i++)
            {
                if (str.Substring(i, 2) == lastTwoChar) // if index i and i+1 has the last two char then add one to count 
                {
                    result++;
                }
                   
            }
            // str.Contains(lastTwoChar) // search for the # of times the substring appears in str and -1 or stop before the last one char

            return result;
        }
    }
}
