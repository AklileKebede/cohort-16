using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]

    public class Less20_Test
    {
        [DataTestMethod]
        [DataRow(19, true)]
        [DataRow(18, true)]
        [DataRow(17,false)]

        public void Modul18or19of20Test(int inputNumber, bool expectedBool)
        {
            Less20 lessTest = new Less20();

            

            Assert.AreEqual(expectedBool, lessTest.IsLessThanMultipleOf20(inputNumber));
        }
    }
}
