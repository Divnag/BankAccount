using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class SavingAccount :Account
    {

        //fields

        private double miniumbalance = 2000;
       
        //properties
        public double MiniumBalance
        {
            get { return this.miniumbalance; }
            set { this.miniumbalance = value; }
        }

     


        //constructors

        public SavingAccount()
        {
            this.AccountNumber = 1234;
            this.Balance = 10000;
        }
        //methods
        public override double BalanceAmount()
        {
            return Balance;
        }

        public override void Deposit(double amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("your Saving amount After deposit;"+Balance);
        }

        public override void Withdraw(double amount)
        {

            while ((Balance - amount) < miniumbalance)
            {
               
                Console.WriteLine("\nThere should be Minium balance of $2000 in the account.Enter different amount");
                amount = double.Parse(Console.ReadLine());
               
            }
            Balance = Balance - amount;
            Console.WriteLine("Your amount in Savings Account of withdraw " + Balance);
           
           
        }
    }
}
