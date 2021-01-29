using BankTellerExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests
{
    [TestClass]
    public class BankCustomerTests
    {
        [TestMethod]
        public void GetCustomerAccounts()
        {
            //Arrange - Creat a customer plus some accounts for that customer
            BankCustomer cust = new BankCustomer();

            SavingsAccount savings = new SavingsAccount("", "");
            CheckingAccount checking1 = new CheckingAccount("", "");
            CheckingAccount checking2 = new CheckingAccount("", "");

            cust.AddAccount(checking1);
            cust.AddAccount(checking2);
            cust.AddAccount(savings);

            //Act- Call GetAccounts
            IAccountable[] actualAccounts = cust.GetAccounts();

            //Assert - Verify all accounts are returnd
            IAccountable[] expectedAccounts = new IAccountable[] { savings, checking1, checking2 };

            CollectionAssert.AreEquivalent(expectedAccounts, actualAccounts);
        }

    }
}
////========================= Array Example ==================================
//[TestMethod]
//public void TestArray()
//{
//    // Arrange
//    int[] initArray = new int[] { 1, 2, 3 };

//    // Act
//    int[] resultArray = BeginEnd(initArray);
//    int[] expectedArray = new int[] { 3, 2, 1 };

//    // Assert
//    CollectionAssert.AreEqual(expectedArray, resultArray); //AreEqual compares both the value and location match (are equal)
//    CollectionAssert.AreEquivalent(expectedArray, resultArray); // AreEquivalaent is used when we only care about that the content of both collection exist (order doesn't matter)
//}