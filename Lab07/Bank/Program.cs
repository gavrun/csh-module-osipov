﻿namespace Bank
{
    internal class Program
    {
        //struct BankAccount
        //{
        //    public long accNo;
        //    public decimal accBal;
        //    public AccountType accType;
        //}

        //enum AccountType
        //{
        //    Checking,
        //    Deposit
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Bank account");

            //AccountType goldAccount;
            //AccountType platinumAccount;

            //goldAccount = AccountType.Checking;
            //platinumAccount = AccountType.Deposit;
            //goldAccount.Equals(AccountType.Checking);

            //Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            //Console.WriteLine("The Customer Account Type is {0}", platinumAccount);

            //BankAccount berts = NewBankAccount();
            //Write(berts);
            //TestDeposit(berts);
            //Write(berts);
            //TestWithdraw(berts);
            //Write(berts);

            //BankAccount freds = NewBankAccount();
            //Write(freds);
            //TestDeposit(freds);
            //Write(freds);
            //TestWithdraw(freds);
            //Write(freds);

            BankAccount b1 = new BankAccount();
            b1.Populate(100);
            BankAccount b2 = new BankAccount();
            b2.Populate(100);

            Console.WriteLine("Before transfer");
            Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance());
            Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance());

            b1.TransferFrom(b2, 10);

            Console.WriteLine("After transfer");
            Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance());
            Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance());
        }

        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            Console.Write("Enter the account balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            created.Populate(balance);

            return created;
        }

        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());
        }

        static void TestDeposit(BankAccount toDeposit)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            toDeposit.Deposit(amount);
        }

        static void TestWithdraw(BankAccount acc)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (!acc.Withdraw(amount))
            {
                Console.WriteLine("Insufficient funds to withdraw.");
            }
        }
    }
}
