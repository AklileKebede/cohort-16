using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public partial class LectureProblem
    {
        /*
         10. What code do we need to write so that we can find the highest
             number in the array randomNumbers?
             TOPIC: Looping Through Arrays
        */
        public int FindTheHighestNumber(int[] randomNumbers)
        {
            int hightestNumber = randomNumbers[0]; // the first hights number we have is the number in index=0

           for (int i=1; i<randomNumbers.Length-1;i++)
            {
                hightestNumber = Math.Max(hightestNumber, randomNumbers[i]);
            }

            return hightestNumber;          
        }
    }
}
