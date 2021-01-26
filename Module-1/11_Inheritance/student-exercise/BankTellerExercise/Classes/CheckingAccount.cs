namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount

    {
        //public decimal OverDraftFee { get; set; }
        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance) { }
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            //If the balance falls below $0.00 and is less than -$100.00, 
            //a $10.00 overdraft fee is also charged against the account.

            decimal overDraftFee = 10.0M;

            if (this.Balance <= -100.0M)
            {
                //Checking account can't be overdrawn by $100.00 or more.
                return this.Balance;
            }
            else if (this.Balance > 0.0M)
            {
               return base.Withdraw(amountToWithdraw);
            }
            else
            {
               return base.Withdraw(amountToWithdraw + overDraftFee);
            }
           
        }


    }




    /* public decimal PerTransactionFee { get; }
    public CheckingAccount(string acctNum, decimal perTransFee): base(acctNum,0)
    {
        PerTransactionFee = perTransFee;
    }
   */


}

