using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private BankAccountType accType;

        private static long nextAccNo = 123;

        public void Populate(decimal balance)
        {
            accNo = NextNumber();
            accBal = balance;
            accType = BankAccountType.Checking;
        }

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

        public decimal Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Deposit amount cannot be negative.");
                return accBal;
            }
            accBal += amount;
            return accBal;
        }

        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds)
            {
                accBal -= amount;
            }
            return sufficientFunds;
        }
        public void TransferFrom(BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
                this.Deposit(amount);
        }
    }
}
