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
        Given two lists of Integers, interleave them beginning with the first element in the first list followed
        by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
        Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
        list to the new list before returning it.
        DIFFICULTY: HARD
        InterleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
        InterleaveLists( [1, 2, 3, 7], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6 , 7]
        InterleaveLists( [1a, 2a, 3a], [4b, 5b, 6b] )  ->  [1a, 4b, 2a, 5b, 3a, 6b]
              Index        0, 1,  2      0, 1 ,2 mod list a  0,  1 ,  2,  3,   4,  5 
        */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            // case 1: both the same size
            // create a new list one time grab from listOne and then grab from listTwo
            // return the new list

            List<int> interleaveList = new List<int>();
            if (listOne.Count== listTwo.Count)
            {
                for (int i = 0; i < listOne.Count; i++)
                {

                    interleaveList.Add(listOne[i]);
                    interleaveList.Add(listTwo[i]);
                }
            }
            else if (listOne.Count > listTwo.Count)
            {
                for (int i = 0; i < listTwo.Count; i++)
                {

                    interleaveList.Add(listOne[i]);
                    interleaveList.Add(listTwo[i]);
                }
               for (int i= listTwo.Count; i<listOne.Count; i++)
                {
                    interleaveList.Add(listOne[i]);
                }
            }
            else
            {
                for (int i=0; i<listOne.Count; i++)
                {
                    interleaveList.Add(listOne[i]);
                    interleaveList.Add(listTwo[i]);
                }
                for (int i=listOne.Count; i < listTwo.Count; i++)
                {
                    interleaveList.Add(listTwo[i]);
                }
            }

            

            // interleave them beginning with the first element in the first list followed by the first element of the second

            // creat a returnList
            // if both lists are eaqual then insert into listOne[i+1] listTwo[i]

           
            return interleaveList;
        }
    }
}
