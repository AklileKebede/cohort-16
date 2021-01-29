using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStart_Test
    {
        [DataTestMethod]
        [DataRow("Hello", "There", "ellohere")]
        [DataRow("java", "code", "avaode")]
        [DataRow("shotl", "java", "hotlava")]
        [DataRow("A","b","",DisplayName ="EdgeCase:1 char each")]
        [DataRow("b","ababa","baba",DisplayName = "EdgeCase: 1 char & regular string")]

        public void CombinString_NoStart_Test(string inputA, string inputB,string expectedResult)
        {
            //Arrange
            NonStart combTest = new NonStart();

            //Act
            string actualResult = combTest.GetPartialString(inputA, inputB);

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
