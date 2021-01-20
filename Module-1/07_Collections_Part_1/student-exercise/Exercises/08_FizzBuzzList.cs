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
        Given an array of Integers, return a List that contains the same Integers (as Strings). Except any multiple of 3
        should be replaced by the String "Fizz", any multiple of 5 should be replaced by the String "Buzz",
        and any multiple of both 3 and 5 should be replaced by the String "FizzBuzz"
        ** INTERVIEW QUESTION **

        FizzBuzzList( {1, 2, 3} )  ->  ["1", "2", "Fizz"]
        FizzBuzzList( {4, 5, 6} )  ->  ["4", "Buzz", "6"]
        FizzBuzzList( {7, 8, 9, 10, 11, 12, 13, 14, 15} )  ->  ["7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"]

        HINT: To convert an integer x to a string you can call x.ToString() in your code (e.g. if x = 1 then x.ToString() equals "1")
        */
        public List<string> FizzBuzzList(int[] integerArray)
        {
            // Resoult should be a List of string
            List<string> returnList = new List<string>();

            // create a loop to go through all the ints
            foreach (int integer in integerArray)
            {
                if (integer % 15 == 0)
                {
                    // change the value with String "FizzBuzz"
                    returnList.Add("FizzBuzz");

                }
                else if (integer % 3 == 0)
                {
                    returnList.Add("Fizz");//replaced by the String "Fizz" 
                }
                else if (integer % 5 == 0)
                {
                    returnList.Add("Buzz");//replaced by the String "Buzz"
                }
                else
                {
                    returnList.Add(integer.ToString());
                }
            }

            return returnList;
        }
    }
}
