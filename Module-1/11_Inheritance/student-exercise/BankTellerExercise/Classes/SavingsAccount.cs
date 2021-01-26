namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {



        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance) { }
        public override decimal Withdraw(decimal amountToWithdraw)
        {

            decimal serviceCharge = 2.00M;

            // If the current balance is less than $150.00 when a withdrawal is made, 
            //an additional $2.00 service charge is withdrawn from the account.
            // we canont withdraw over balance 0
            //If a withdrawal is requested for more than the current balance, the withdrawal fails and balance remains the same.

            if (this.Balance < 150.0M +serviceCharge && this.Balance >= amountToWithdraw + serviceCharge)
            {
                return base.Withdraw(amountToWithdraw + serviceCharge);
            }
            else if (this.Balance >= 150.0M && this.Balance>= amountToWithdraw) //+ amountToWithdraw )
            {
                return base.Withdraw(amountToWithdraw);
            }
            else return this.Balance;




            /*
            if (amountToWithdraw >= this.Balance || this.Balance <= 0)
            {
                return this.Balance;
            }
            else if (amountToWithdraw + serviceCharge < 150.0M)
            {
                return base.Withdraw(amountToWithdraw + serviceCharge);
            
            else if (amountToWithdraw + serviceCharge >= 150.0M)
            {
                return base.Withdraw(amountToWithdraw);

            }
            else if (this.Balance < 150.0M  )
            {
                if (amountToWithdraw + serviceCharge >= 2.0M)
                {
                    return base.Withdraw(amountToWithdraw + serviceCharge);
                }
                return base.Withdraw(amountToWithdraw + serviceCharge);

            }
            
            return base.Withdraw(amountToWithdraw);*/
        }


        /* public SavingsAccount(string number, decimal bal) : base("acountNumber", "0")
         {
             System.Console.WriteLine("In SavingAccount constructor");
         }
         public override decimal Withdraw(decimal amToWithdraw)
         {
             // Don't allow overdraw
             if (amToWithdraw > Balance)
             {
                 System.Console.WriteLine("ERROR! You don't have it!");
                 return 0;
             }
             // I now know I have enough
             return base.Withdraw(amToWithdraw);
         }*/
    }
}
