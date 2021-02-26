using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Assessment.Models;

namespace Assessment.Tests
{
    [TestClass]
    public class AssessmentTest
    {
        [DataTestMethod]
        [DataRow("123456",false)]//6
        [DataRow("34123456", true)] //8
        [DataRow("34723", true)]//5
        [DataRow("5234567891011121", true)]//16
        [DataRow("4234567891011121", true)]//17
        [DataRow("4234567891011", true)]//13
        public void CarNumberValidTest(string carNumberString,bool expectedResult)
        {
            //Arrange
            TellerMachine tellerTest = new TellerMachine("manufact", 200, 20);
            //Act
            bool actualResult = tellerTest.IsValid(carNumberString);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow(20.00, 10.00, 10.00)]
        [DataRow(20.00, 25.00, -5.00)]
        [DataRow(20.00, 20.00, 0.00)]
        public void IsBalanceCorrect (double deposit, double withdrawal, double expectedResult)
        {
            //Arrange
            TellerMachine tellerTest = new TellerMachine("manufact", deposit, withdrawal);
            //Act
            double actualResult = tellerTest.Balance;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
