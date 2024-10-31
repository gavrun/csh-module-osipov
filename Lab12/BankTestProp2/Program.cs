using System;
using System.Collections;
using Banking5;

namespace BankTestProp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create two bank accounts
            long accNo1 = Bank.CreateAccount(BankAccountType.Checking, 100);
            long accNo2 = Bank.CreateAccount(BankAccountType.Checking, 100);

            // populate variables
            BankAccount acc1 = Bank.GetAccount(accNo1);
            BankAccount acc2 = Bank.GetAccount(accNo2);

            // toss some money
            acc1.Deposit(100);
            acc2.Deposit(200);
            acc1.Withdraw(50);
            acc2.Withdraw(30);

            // call history
            Write(acc1);
            Write(acc2);

            // my string format
            Console.WriteLine();
            Console.WriteLine("acc1 - {0}", acc1);
            Console.WriteLine("acc2 - {0}", acc2);
        }

        static void Write(BankAccount acc)
        {
            Console.WriteLine("Account number is {0}", acc.Number);
            Console.WriteLine("Account balance is {0}", acc.Balance());
            Console.WriteLine("Account type is {0}", acc.Type);

            // Print out the transactions (if any)
            Console.WriteLine("Transactions");
            Queue tranQueue = acc.Transactions();
            foreach (BankTransaction tran in tranQueue)
            {
                Console.WriteLine("Date: {0}\tAmount: {1}", tran.When, tran.Amount);
            }
        }
    }
}
