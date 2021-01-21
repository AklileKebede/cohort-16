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
         * Given an array of strings, return a Dictionary<string, int> with a key for each different string, 
         * with the value the number of times that string appears in the array.
         *
         * ** A CLASSIC **
         *
         * WordCount(["ba","ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
         * WordCount(["a", "b", "a", "c", "b"]) → {"b": 2, "c": 1, "a": 2}
         * WordCount([]) → {}
         * WordCount(["c", "b", "a"]) → {"b": 1, "c": 1, "a": 1}
         *
         */
        public Dictionary<string, int> WordCount(string[] words)
        {
            // count how many times a word apears
            //Add to dictionary Key= wordKey && Value= countKey 
            // Creat new Dictionary<string, int>
            Dictionary<string, int> wordCountDictionary = new Dictionary<string, int>();
            // creat a var string and var int count

            // take each word in string 
            foreach (string wordKey in words)
            {
                int countWord = 0;
                // we need to count how many times a wordKey comes up
                foreach (string word in words)
                {
                    
                    if (wordKey == word)
                    {
                        countWord++;
                        wordCountDictionary[word] = countWord;
                    }
                }
            }
            return wordCountDictionary;
        }
    }
}
