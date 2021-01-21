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
         * Given an array of non-empty strings, return a Dictionary<string, string> where for every different string in the array,
         * there is a key of its first character with the value of its last character.
         *
         * BeginningAndEnding(["code", "bug"]) → {"b": "g",
         *                                        "c": "e"}
         * BeginningAndEnding(["man", "moon", "main"]) → {"m": "n"}
         * BeginningAndEnding(["muddy", "good", "moat", "good", "night"]) → {"g": "d",
         *                                                                   "m": "t", 
         *                                                                   "n": "t"}
         */
        public Dictionary<string, string> BeginningAndEnding(string[] words)
        {
             //create a dictionary that will be populated <string, string>=<first letter [i], last letter [i]>
           
            Dictionary<string, string> firstAndLastLetterDictionary = new Dictionary<string, string>();

            // Declare var for firstLetter and LastLetter
            string firstLetter;
            string lastLetter;
            foreach (string word in words)
            {
                // locate: first letter (key) && last letter (value) of each index
                firstLetter = word.Substring(0,1);
                lastLetter= word.Substring(word.Length - 1);
                // add to dictionary: first letter as key, last letter as value
                firstAndLastLetterDictionary[firstLetter] = lastLetter;
            }
            
            return firstAndLastLetterDictionary;
        }
    }
}
