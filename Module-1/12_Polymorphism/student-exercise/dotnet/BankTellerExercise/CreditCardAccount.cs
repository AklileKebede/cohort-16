using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class CreditCardAccount :IAccountable
    {
        public string AccountHolderName { get; }
        public string AccountNumber { get; }
        public int Debt { get; private set; }
        public int Balance //The balance for the accounting must be the debt as a negative number.
        {
            get
            {
                return this.Debt * (-1);
            }
        } 
        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            Debt = 0;
        }

        public int Pay(int amountToPay)
        {
            this.Debt -= amountToPay;
            return this.Debt;
            
        }
        public int Charge(int amountToCharge)
        {
            this.Debt += amountToCharge;
            return this.Debt;
        }
    }
}
