using System;
using System.Collections.Generic;
using System.Text;

namespace FizzWriter
{
    public class FizzBuzz
    {
        public int StartNumber { get; }
        public int EndNumber { get; }
        public int FizzNumber { get; }
        public int BuzzNumber { get; }
        public int FizzBuzzNumber { get; }

        public List<string> retunList = new List<string>();

        public FizzBuzz(int start, int end, int fizz, int buzz)
        {
            this.StartNumber = start;
            this.EndNumber = end;
            this.FizzNumber = fizz;
            this.BuzzNumber = buzz;
            this.FizzBuzzNumber = fizz * buzz;
        }
        public List<string> FizzBuzzList()
        {
            // Resoult should be a List of string
            List<string> returnList = new List<string>();

            // create a loop to go through all the ints
            for (int i=this.StartNumber; i<=this.EndNumber;i++ )
            {
                if (i % this.FizzBuzzNumber == 0)
                {
                    // change the value with String "FizzBuzz"
                    returnList.Add("FizzBuzz");

                }
                else if (i % this.FizzNumber == 0)
                {
                    returnList.Add("Fizz");//replaced by the String "Fizz" 
                }
                else if (i % this.BuzzNumber == 0)
                {
                    returnList.Add("Buzz");//replaced by the String "Buzz"
                }
                else
                {
                    returnList.Add(i.ToString());
                }
            }

            return returnList;
        }
    }
}
