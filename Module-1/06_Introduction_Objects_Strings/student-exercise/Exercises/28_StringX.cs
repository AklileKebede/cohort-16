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
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end
        should not be removed.
        StringX("xxHxix") → "xHix"
        StringX("abxxxcd") → "abcd"
        StringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            // if remove all x's other then the ones on i=0 and i= str.Length-1

            // loop looking for x in each index, 
            // remove all the x's other the the once in i=0 and index= str.Length-1

            string removeX = "";

            if (str.Length<=2) 
            {
                return str;
            }

            
            for (int i=1; i < str.Length - 1; i++)
            {
                if (str.Substring(i,1)!="x") 
                {
                    removeX += str.Substring(i,1);
                }
            }
            return str.Substring(0,1)+removeX+str.Substring(str.Length-1);
           
        }
    }
}
