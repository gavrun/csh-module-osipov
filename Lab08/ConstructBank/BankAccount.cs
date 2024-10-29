using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructBank
{
    internal class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private BankAccountType accType;

        private static long nextAccNo = 123;

        private Queue tranQueue = new Queue();

        /*public BankAccount()
        {
            default ctor;
        }*/
        public BankAccount() 
        {
            accNo = NextNumber();
            accType = BankAccountType.Checking;
            accBal = 0;
        }
        public BankAccount(BankAccountType aType)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = 0;
        }
        public BankAccount(decimal aBal)
        {
            accNo = NextNumber();
            accType = BankAccountType.Checking;
            accBal = aBal;
        }
        public BankAccount(BankAccountType aType, decimal aBal)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = aBal;
        }

        //public void Populate(decimal balance)
        //{
        //    accNo = NextNumber();
        //    accBal = balance;
        //    accType = BankAccountType.Checking;
        //}

        private static long NextNumber()
        {
            return nextAccNo++;
        }

        public long Number()
        {
            return accNo;
        }
        public decimal Balance()
        {
            return accBal;
        }
        public string Type()
        {
            return accType.ToString();
        }

        public Queue Transactions()
        {
            return tranQueue;
        }

        public decimal Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Deposit amount cannot be negative.");
                return accBal;
            }
            accBal += amount;

            BankTransaction tran = new BankTransaction(amount);
            tranQueue.Enqueue(tran);

            return accBal;
        }

        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds)
            {
                accBal -= amount;
            }

            BankTransaction tran = new BankTransaction(-amount);
            tranQueue.Enqueue(tran);

            return sufficientFunds;
        }
        public void TransferFrom(BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
                this.Deposit(amount);
        }
    }
}
