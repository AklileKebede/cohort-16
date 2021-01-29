using BankTellerExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void Constructor_TwoParameterTest()
        {
            // 3.Arrange- Sometimes we can fill this in the end, we want to use parameters so we don't make a spelling mistake
            string name = "Aklile";
            string num = "123456";
           
            //1. Act- This would be the first thing to do
            BankAccount account = new BankAccount(name, num);

            //2.Assert- Make sure the holder, acct number and blance are all correct
            Assert.AreEqual(name, account.AccountHolderName);
            Assert.AreEqual(num, account.AccountNumber);
            Assert.AreEqual(0, account.Balance);

        }   
        [TestMethod]
        public void Constructor_TwoParameters_NullName_ShouldFailArgumentException()// Testing the TransferTo method
            //TransferMoney()
        {
            //2.Arrange- Creat two accounts for testing transferring money
            BankAccount account = new BankAccount("", "", 1000);
            BankAccount someOtherAccount = new BankAccount("", "", 10);

            //1.Act- What am I trying to test?! this should be the 1st to be answered // 
            account.TransferTo(someOtherAccount, 500);//3. fill in the missing info needed
            // int transferredAmount = account.TransferTo(someOtherAccount, 600)

            //Asset-
            Assert.AreEqual(500, account.Balance);
            Assert.AreEqual(510, someOtherAccount.Balance);
            // Assert.areEqual(600, transferredAmount);
        }
        private int MySpecialMethod()
        {
            return 0;
        }
    }
}
