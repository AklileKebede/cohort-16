using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{/*
    Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
    GetBits("Hello") → "Hlo"	
    GetBits("Hi") → "H"	
    GetBits("Heeololeo") → "Hello"
    public string GetBits(string str)
 */
    [TestClass]
    public class StringBitsTests
    {
        [DataTestMethod]
        [DataRow("Hello", "Hlo")]
        [DataRow("He", "H")]
        [DataRow("Hoeololeo", "Hello")]
        [DataRow("Aklile", "All")]
        [DataRow("", "")]
        [DataRow("A", "A")]
        public void TestNewString_EveryOtherChar(string inputWord, string expectedOutputWord)
        {
            //Arrange
            // Create result with inputWord

            StringBits bits = new StringBits();


            //Act
            // Invoke the GetBits method
            string actualOutputWord = bits.GetBits(inputWord);

            //Assert
            //verify the shortWord is returned
            Assert.AreEqual(expectedOutputWord, actualOutputWord);
        }

    }
}
