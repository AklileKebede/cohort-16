using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimes_Test
    {/*"Chocolate", 2) → "ChoCho"	
         frontTimes("Chocolate", 3) → "ChoChoCho"	
         frontTimes("Abc", 3) → "AbcAbcAbc"	*/
        [DataTestMethod]
        [DataRow("Chocolate", 2,"ChoCho")]
        [DataRow("Chocolate", 3,"ChoChoCho")]
        [DataRow("Abc", 3, "AbcAbcAbc")]
        [DataRow("Aklile",0,"",DisplayName ="EdgeCase: 0 times")]
        [DataRow("a", 2, "aa", DisplayName = "EdgeCase: 1 char")]
        

        public void RepeateNTimes(string inputString, int inputInt, string expectedResult)
        {
            //Arreng
            FrontTimes stringTest = new FrontTimes();
            //Assert
            Assert.AreEqual(expectedResult, stringTest.GenerateString(inputString, inputInt));
        }
    }
}
