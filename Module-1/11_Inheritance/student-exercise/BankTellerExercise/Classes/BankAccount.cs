namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
       
        #region Properties
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }
        #endregion

        #region Constructors
        public BankAccount(string accountHolderName,string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            Balance = 0;
            
            
        }
        public BankAccount(string accountHolderName, string accountNumber,decimal balance)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
            
        }
        #endregion
        #region Methods

        public decimal Deposit(decimal amountToDeposit) 
        {
            //Adds amountToDeposit to the current balance, 
            //and returns the new balance of the bank account.
            Balance += amountToDeposit;
            return Balance;
        }

        virtual public decimal Withdraw (decimal amountToWithdraw)
        {
            //Subtracts amountToWithdraw from the current balance, 
            //and returns the new balance of the bank account.

            Balance -= amountToWithdraw;
            return Balance;
        }
        #endregion

        /*  public string CheckingAccount { get; set; }
         public decimal SavingsAccount { get; private set; }
       */
        /* public BankAccount (string accountNumber, decimal initialBlance)
         {
             System.Console.WriteLine("In BankAccount constructor");

             CheckingAccount = accountNumber;
             Balance = initialBlance;
         }
         public virtual decimal Withdraw (decimal amtToWithdraw)
         {
             Balance -= amtToWithdraw;
             return amtToWithdraw;
         }
         public decimal Deposit (decimal amtoDeposit)
         {
             Balance += amtoDeposit;
             return Balance;
         }
        */
    }
}
