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
         * Just when you thought it was safe to get back in the water --- Last2Revisited!!!!
         *
         * Given an array of strings, for each string, the count of the number of times that a substring length 2 appears
         * in the string and also as the last 2 chars of the string, so "hixxxhi" yields 1.
         *
         * We don't count the end substring, but the substring may overlap a prior position by one.  For instance, "xxxx"
         * has a count of 2, one pair at position 0, and the second at position 1. The third pair at position 2 is the
         * end substring, which we don't count.
         *
         * Return Dictionary<string, int>, where the key is string from the array, and its last2 count.
         *
         * Last2Revisited(["hixxhi",     →   {"hixxhi": 1, 
         *                 "xaxxaxaxx",       "xaxxaxaxx": 1,
         *                 "axxxaaxx"])         "axxxaaxx": 2}
         */
        public Dictionary<string, int> Last2Revisited(string[] words)
        {
            Dictionary<string, int> lastTwoDictionary = new Dictionary<string, int>(); // creat a new dictionary
            // creat a loop to go through to array
            foreach ( string word in words)
            {
                lastTwoDictionary[word] = Last2(word);
            }
            return lastTwoDictionary;
        }
        public int Last2(string str)
        {
            // Todo: 1. check string length >2
            if (str.Length <= 2)
            {
                return 0;
            }

            string lastTwoChar = str.Substring(str.Length - 2); // identify the last two char as substring to find
            int result = 0;

            for (int i = 0; i < str.Length - 2; i++)
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

