using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    /* A key for each different string, with the value the 
     * number of times that string appears in the array.
                  Given an array of strings      --> return a Dictionary<string, int>
       * GetCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
       * GetCount(["a", "b", "a", "c", "b"]) → {"a": 2, "b": 2, "c": 1}
       * GetCount([]) → {}
       * GetCount(["c", "b", "a"]) → {"c": 1, "b": 1, "a": 1}
    */
    [TestClass]
    public class WordCountTests
    {
        [TestMethod]
        public void GetDictionary_StringCountTest()
        {
            // Arrange
            //Creat new array of string
            string word1 = "a";
            string word2 = "Two";
            string word3 = "Tree";
            string word4 = "Four";

            string[] getCountArray = new string[] { word1,word2,word3,word4, word3 };

            // creat new dictionary<string something, int countSomethings>  
            Dictionary<string, int> getCountDictionary = new Dictionary<string, int>()
            {   {word1 , 1 },
                { word2, 1 },
                { word3, 2 },
                {word4,1 }
            };
            //Act
            //Invoke/Call GetCount
            Dictionary<string, int> GetCount = getCountDictionary;

            // add getCountArray to Dictionary
            //Assert
            CollectionAssert.AreEquivalent(getCountDictionary,GetCount);
        }
    }
}
