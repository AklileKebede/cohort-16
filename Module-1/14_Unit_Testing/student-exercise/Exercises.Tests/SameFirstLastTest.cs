using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
       [DataTestMethod]
       [DataRow(new int[] { 1, 2, 3, 4 },false)]
       [DataRow(new int[] { 1, 2, 3, 4, 5 }, false)]
       [DataRow(new int[] { 1 }, true)]
       [DataRow(new int[] { }, false,DisplayName ="Edge Case")]
       [DataRow(new int[] { 112, 23, 54, 112 }, true)]
       [DataRow(new int[] { -112, 23, 54, 112 }, false)]
       [DataRow(new int[] { -112, 23, 54, -112 }, true)]


        public void IsMoreThenOne_IsSameFirstLast_Test(int[] inputArray,bool expectedResult)
        {
            //Arrange
            // creat new Array
            SameFirstLast arrayTest = new SameFirstLast();
            
            //Act
            // Invoke IsItSame method
            bool actualResult = arrayTest.IsItTheSame(inputArray);
            

            //Assert
            //return true if method result is same as
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
