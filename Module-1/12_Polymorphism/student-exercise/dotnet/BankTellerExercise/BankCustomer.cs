using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class BankCustomer : IAccountable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip //Calculates the balance of all accounts, returns true if at least $25,000; otherwise is false.
        {
            get
            {
                int sum = 0;
                    foreach (IAccountable account in totalAccounts)
                {
                    sum += account.Balance;
                }
                return sum>=25000 ? true: false;
                
            }
                }


        public int Balance { get; }

        public BankCustomer() //Default Constructor
        {

        }

       private List<IAccountable> totalAccounts = new List<IAccountable>();

        public void AddAccount(IAccountable newAccount)
        {
            totalAccounts.Add(newAccount);
        }

        public IAccountable[] GetAccounts()
        {
            return totalAccounts.ToArray();
        }

    }
}
