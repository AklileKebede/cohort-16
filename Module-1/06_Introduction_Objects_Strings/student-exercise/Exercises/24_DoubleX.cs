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
         Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
         DoubleX("axxbb") → true
         DoubleX("axaxax") → false
         DoubleX("xxxxx") → true
         */
        public bool DoubleX(string str)
        {
            int firstX = str.IndexOf("x");

            if (firstX < 0 || firstX == str.Length - 1)
            {
                return false;
            }
            else if (str[firstX + 1] == 'x')
            {
                return true;
            }
            return false;
            //{
                
            //    if (str.Substring(i) == "x")
            //    {
            //        if (str.Substring(i + 1) == "x")
            //        {
            //            return true;
            //        }
            //    }
            //}

            //return false;
        }
    }
}
