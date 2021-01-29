using BankTellerExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests
{
    [TestClass]
    public class SavingsAccountTests
    {
        //[TestMethod]
        //public void Withdraw()
        //{
        //    //Arrange-
        //    // Creat a savings account with initial balance
        //    SavingsAccount account = new SavingsAccount("Holder", "1234", 500);

        //    //Act
        //    // Call/Invoke the Withdraw method
        //    int returnValue = account.Withdraw(100);

        //    // Assert
        //    // Verify the return value
        //    Assert.AreEqual(400, returnValue);

        //    // Verify the new balance is correct
        //    Assert.AreEqual(400, account.Balance);
        //}

        [DataTestMethod]
        [DataRow(500, 100, 400, DisplayName ="Happy path Withdrawal")]// The parameters at DataRow need to match in type to the method parameters
        [DataRow(500, 150, 350)]
        [DataRow(500, 351, 147, DisplayName ="Edge case, balance goes to <150, $2 Fee is charged")]
        [DataRow(500, 498, 0)]
        [DataRow(500, 499, 500)]
        public void Withdraw_DataTestMethod(int startingBalance, int withdrawalAmount, int expectedNewBalance)
        {
            //Arrange-
            // Creat a savings account with initial balance
            SavingsAccount account = new SavingsAccount("Holder", "1234", startingBalance);

            //Act
            // Call/Invoke the Withdraw method
            int returnValue = account.Withdraw(withdrawalAmount);

            // Assert
            // Verify the return value
            Assert.AreEqual(expectedNewBalance, returnValue);

            // Verify the new balance is correct
            Assert.AreEqual(expectedNewBalance, account.Balance);
        }
        
    }
}
