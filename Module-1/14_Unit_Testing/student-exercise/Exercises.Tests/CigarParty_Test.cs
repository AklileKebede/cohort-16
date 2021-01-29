using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarParty_Test
    {
        
        [DataTestMethod]
        [DataRow(30, false, false)]
        [DataRow(40, false, true, DisplayName ="EdgeCase: 40 cigars during the week")]
        [DataRow(60, false, true, DisplayName = "EdgeCase: 60 cigars during the week")]
        [DataRow(30, true, false)]
        [DataRow(40, true, true, DisplayName = "EdgeCase: 40 cigars during the weekend")]
        [DataRow(60, true, true, DisplayName = "EdgeCase: 60 cigars during the weekend")]
        public void HaveParty_Test(int cigarInput, bool weekendInput, bool expectedOutput)
        {
            /*
             Cigars --> Weekend -->successful
              40 - 60, inclusive --> false --> true
              min 40  --> true --> true
            */
            //Arrange
            CigarParty partyTest = new CigarParty();

            //Act
            bool actualOutput = partyTest.HaveParty(cigarInput, weekendInput);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
