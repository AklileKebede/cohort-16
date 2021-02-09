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
<<<<<<< HEAD
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
=======
            List<int> finalList = new List<int>();

            if (listOne.Count > listTwo.Count) {
                //add from both lists up to the end of list two, because it is smaller
                for (int i=0;i<listTwo.Count;i++) {
                    finalList.Add(listOne[i]);
                    finalList.Add(listTwo[i]);
                }
                //add the rest of the items from list 1
                for (int i=listTwo.Count;i<listOne.Count;i++) {
                    finalList.Add(listOne[i]);
                }
            } else {
                //list two is greater OR they are equal
                for (int i=0;i<listOne.Count;i++) {
                    finalList.Add(listOne[i]);
                    finalList.Add(listTwo[i]);
                }

                //add the rest of the items from list 2 (if equal, the loop wont run)
                for (int i = listOne.Count;i<listTwo.Count;i++) {
                    finalList.Add(listTwo[i]);
                }
            }

            return finalList;
>>>>>>> 2a35320594bb288d1ed7d189c85c5727f0bfcad4
        }
    }
}
