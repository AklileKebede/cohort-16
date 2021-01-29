using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    
    public class AnimalGroupName_Test
    {
        [DataTestMethod]
        [DataRow("rhino", "Crash")]
       [DataRow(null,"unknown",DisplayName ="EdgeCase null")]// If running Null exception test this shouldn't be here.
        [DataRow("", "unknown", DisplayName = "EdgeCase empty")]
        [DataRow("walrus", "unknown", DisplayName = "EdgeCase not in list")]


        public void FindHerdTest(string inputAnmial, string expectedHerd)
        {
            //Arrange
            AnimalGroupName animal = new AnimalGroupName();
            //Act- invoke
            string actualHerd = animal.GetHerd(inputAnmial);

            //Assert
            Assert.AreEqual(expectedHerd, actualHerd);
        }

        /*
         * ======================NullReferenceException==============================*
        [TestMethod] // EdgeCase NoNull
              
       [ExpectedException(typeof(NullReferenceException),"You ran a null case, remove that")]
        public void FindHerdNullTest()
        {
            //Arrange
            AnimalGroupName animal = new AnimalGroupName();
            
            //Act- invoke
            string actualHerd = animal.GetHerd(null);

            //Assert
            //Assert.AreEqual(expectedHerd, actualHerd);
            //Assert.ThrowsException<NullReferenceException>
        }

        */
    }
}
