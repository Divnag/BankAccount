using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {

            Client mem = new Client();
            CheckingAccount check = new CheckingAccount();
            SavingAccount save = new SavingAccount();
            int input;
            do
            {
                
                Console.WriteLine("\nView Client Informatin: Select 1");
                Console.WriteLine("View Account Balance: select 2");
                Console.WriteLine("Deposit Funds select 3");
                Console.WriteLine("Withdraw Fund Select 4");
                Console.WriteLine("Exit select 5");





                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        mem.ClientInfo();
                        break;

                    case 2:
                        Console.WriteLine("Checking Account Select 1\n Savings Account select 2");
                        int acc;
                        acc = int.Parse(Console.ReadLine());

                        switch (acc)
                        {
                            case 1:

                                Console.WriteLine("\nChecking account Balance amount:" + check.BalanceAmount());
                                break;
                            case 2:
                                Console.WriteLine("\nSaving account Balance amount:" + save.BalanceAmount());
                                save.BalanceAmount();
                                break;
                            default:
                                break;
                        }
                        break;



                    case 3:
                        Console.WriteLine("Checking Account Select 1\n Savings Account select 2");
                        int acc1;
                        acc1 = int.Parse(Console.ReadLine());

                        switch (acc1)
                        {
                            case 1:
                                Console.WriteLine("enter the amount to deposit");
                                int amount = int.Parse(Console.ReadLine());
                                check.Deposit(amount);
                                break;
                            case 2:
                                Console.WriteLine("enter the amount to deposit");
                                int amount1 = int.Parse(Console.ReadLine());
                                save.Deposit(amount1);
                                break;

                            default:
                                break;
                        }
                        break;

                    case 4:
                        Console.WriteLine("Checking Account Select 1\n Savings Account select 2");
                        int acc2;
                        acc2 = int.Parse(Console.ReadLine());

                        switch (acc2)
                        {
                            case 1:
                                Console.WriteLine("enter the amount to withdraw");
                                int amount = int.Parse(Console.ReadLine());
                                check.Withdraw(amount);
                                break;
                            case 2:
                                Console.WriteLine("enter the amount to Withdraw");
                                int amount1 = int.Parse(Console.ReadLine());
                                save.Withdraw(amount1);
                                break;

                            default:
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Signed Out");
                        break;

                }

            } while (input != 5);

        }
    }
}
