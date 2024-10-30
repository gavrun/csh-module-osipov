using Banking2;

namespace BankTestHarness
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long accNo1 = Bank.CreateAccount(BankAccountType.Checking, 100);
            long accNo2 = Bank.CreateAccount(BankAccountType.Checking, 100);

            BankAccount acc1 = Bank.GetAccount(accNo1);
            BankAccount acc2 = Bank.GetAccount(accNo2);

            // testing binary operators

            //if (acc1 == acc2)
            //{
            //    Console.WriteLine("Both accounts are the same. They should not be!");
            //}
            //else
            //{
            //    Console.WriteLine("The accounts are different. Good!");
            //}
            //if (acc1 != acc2)
            //{
            //    Console.WriteLine("The accounts are different. Good!");
            //}
            //else
            //{
            //    Console.WriteLine("Both accounts are the same. They should not be!");
            //}

            BankAccount acc3 = Bank.GetAccount(accNo1);

            //if (acc1 == acc3)
            //{
            //    Console.WriteLine("The accounts are the same. Good!");
            //}
            //else
            //{
            //    Console.WriteLine("The accounts are different.They should not be!");
            //}
            //if (acc1 != acc3)
            //{
            //    Console.WriteLine("The accounts are different.They should not be!");
            //}
            //else
            //{
            //    Console.WriteLine("The accounts are the same. Good!");
            //}

            // testing object methods

            if (acc1.Equals(acc2))
            {
                Console.WriteLine("Both accounts are the same. They should not be!");
            }
            else
            {
                Console.WriteLine("The accounts are different. Good!");
            }

            if (!acc1.Equals(acc2))
            {
                Console.WriteLine("The accounts are different. Good!");
            }
            else
            {
                Console.WriteLine("Both accounts are the same. They should not be!");
            }
            if (acc1 != acc3)
            {
                Console.WriteLine("The accounts are different. They should not be!");
            }
            else
            {
                Console.WriteLine("The accounts are the same. Good!");
            }
            Console.WriteLine();
            Console.WriteLine("acc1 – {0}", acc1);
            Console.WriteLine("acc2 – {0}", acc2);
            Console.WriteLine("acc3 – {0}", acc3);

        }

        //static void Write(BankAccount acc)
        //{
        //    Console.WriteLine("Account number is {0}", acc.Number());
        //    Console.WriteLine("Account balance is {0}", acc.Balance());
        //    Console.WriteLine("Account type is {0}", acc.Type());

        //    // Print out the transactions (if any)
        //    Console.WriteLine("Transactions");
        //    Queue tranQueue = acc.Transactions();
        //    foreach (BankTransaction tran in tranQueue)
        //    {
        //        Console.WriteLine("Date: {0}\tAmount: {1}", tran.When(), tran.Amount());
        //    }
        //}
    }
}
