using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13_Test
    {
            [DataTestMethod]
            [DataRow(new int[] { 1, 2, 3, 4 }, false)]
            [DataRow(new int[] { 1, 2, 4, 5 }, false)]
            [DataRow(new int[] { 2 }, true)]
            [DataRow(new int[] { }, true, DisplayName = "Edge Case")]
            [DataRow(new int[] { 112, 23, 54, 112 }, true)]
            [DataRow(new int[] { -112, 1, 54, 112 }, false)]
            [DataRow(new int[] { 2,3,4,5 }, false)]


            public void NoOneOrThreeReturnTrue_Test(int[] inputArray, bool expectedResult)
            {
                //Arrange
                // creat new Array
                Lucky13 arrayTest = new Lucky13();

                //Act
                // Invoke IsItSame method
                bool actualResult = arrayTest.GetLucky(inputArray);


                //Assert
                //return true if method result is same as
                Assert.AreEqual(actualResult, expectedResult);
            }
       
    }
}
