using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        private List<string> transactionLog;
        // TODO 05: Change the Transaction Log so that the caller cannot modify it.

        public string[] TransactionLog
        {
            get
            {
                return transactionLog.ToArray();
            }
        }


         public Account()// default constructor 
        {
            this.AccountNumber = GenerateNewAccountNumber();
            this.Balance = 0.0M;

            // Create the empty transaction log
            transactionLog = new List<string>();
            transactionLog.Add($"Account {AccountNumber}: Created with Balance {Balance}.");
        }
      


        public Account(string accountNumber, decimal initialBalance)
        {
            //Console.WriteLine("In Account constructor");

            AccountNumber = accountNumber;
            Balance = initialBalance;

            // Create the empty transaction log
            transactionLog = new List<string>();
            transactionLog.Add($"Account {AccountNumber}: Created with Balance {Balance}.");
        }

        virtual public decimal Withdraw(decimal amtToWithdraw)
        {
            Balance -= amtToWithdraw;
            transactionLog.Add($"Account {AccountNumber}: Withdrawal of {amtToWithdraw:C}, remaining balance {Balance:C}.");

            return amtToWithdraw;
        }

        public decimal Deposit(decimal amtToDeposit)
        {
            Balance += amtToDeposit;
            transactionLog.Add($"Account {AccountNumber}: Deposit of {amtToDeposit:C}, new balance {Balance:C}.");

            return Balance;
        }

        // TODO 01:+ Add a Transfer method to the Account class. What Type is its "toAccount" parameter?
        public void TransferTo(decimal amount, Account toAccount)
        {
            decimal amtWithdraw = this.Withdraw(amount);
            if (amtWithdraw > 0)
            {
                toAccount.Deposit(amtWithdraw);
            }
        }
        private string GenerateNewAccountNumber()
        {
            return "xxxxx";

        }
    }
}
