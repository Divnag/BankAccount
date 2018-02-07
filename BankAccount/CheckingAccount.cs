using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
   public class CheckingAccount : Account
    {

        //fields
       
       //properties

        //constructors
        public CheckingAccount()
        {
            this.AccountNumber = 1234;
            this.Balance = 15000;
        }


        //method


        public override double BalanceAmount()
        {
           
            return Balance;
          
        }


        public override void Deposit(double amount)
        {
            Balance +=amount;
            Console.WriteLine("Balance amount in Checking account after deposit:"+Balance);
        }


        public override void Withdraw(double amount)
        {
            Balance = Balance - amount;
            Console.WriteLine("Balance amount in Checking account after Withdraw:"+Balance);
        }

    }
}
