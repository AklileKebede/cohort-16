using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]

    public class MaxEnd3_Test
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3 },new int[] {3, 3, 3})]
        [DataRow(new int[] { 11, 5, 9 },new int[] {11, 11, 11})]
        [DataRow(new int[] { 2, 11, 3 },new int[] { 3, 3, 3 })]

        public void NewArrayFromOldLargeNumber_Test(int[] input, int[] expectedresult)
        {
    //Arrange
    MaxEnd3 arrayTest = new MaxEnd3();

    //Act
    int[] actualResult = arrayTest.MakeArray(input);

    //Assert
    CollectionAssert.AreEqual(actualResult, expectedresult);
        }
    }
}
