using System;
using System.Collections;
using Banking6;

namespace BankTestIndexer
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

            // my string format
            //Console.WriteLine();
            Console.WriteLine("acc1 - {0}", acc1);
            Console.WriteLine("acc2 - {0}", acc2);

            // toss some money and call history
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                acc1.Deposit(100);
                acc1.Withdraw(50);
            }
            Write(acc1);

            Console.WriteLine();
            Console.WriteLine("acc1 - {0}", acc1);
            Console.WriteLine("acc2 - {0}", acc2);
        }
        static void Write(BankAccount acc)
        {
            Console.WriteLine("Account number is {0}", acc.Number);
            Console.WriteLine("Account balance is {0}", acc.Balance());
            Console.WriteLine("Account type is {0}", acc.Type);

            Console.WriteLine("Transactions");
            Queue tranQueue = acc.Transactions();

            //foreach (BankTransaction tran in tranQueue) {
            //	Console.WriteLine("Date: {0}\tAmount: {1}", tran.When, tran.Amount);
            //}

            // loop that uses an indexer
            for (int counter = 0; counter < tranQueue.Count; counter++)
            {
                BankTransaction tran = acc[counter];
                Console.WriteLine("Date: {0}\tAmount: {1}", tran.When, tran.Amount);
            }
        }
    }
}
