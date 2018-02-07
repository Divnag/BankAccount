using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public abstract class Account
    {
        private int accountNumber = 1234;
        private string accountType;
        private string action;
        private double balance ;

        //properties                    
        public int AccountNumber
        {
            get { return this.accountNumber; }
           set { this.accountNumber = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
        }

        public string Action
        {
            get { return this.action; }
            set { this.action = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        //no need of making constructors since we never make an instance of that abject its abstract

            //constructors

            //methods

        public abstract double BalanceAmount();
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);

    }

}
