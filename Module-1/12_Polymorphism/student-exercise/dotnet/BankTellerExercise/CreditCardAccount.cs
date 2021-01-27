using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class CreditCardAccount :IAccountable
    {
        public string AccountHolderName { get; }
        public string AccountNumber { get; }
        public int Debt 
        {
            get
            {
                return -1 * Balance;
            }
                }
        public int Balance //The balance for the accounting must be the debt as a negative number.
        {
            get; private set;
            
        } 
        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
           
        }

        public int Pay(int amountToPay)
        {
            Balance += amountToPay;
            return this.Debt;
            
        }
        public int Charge(int amountToCharge)
        {
            Balance -= amountToCharge;
            return this.Debt;
        }
    }
}
