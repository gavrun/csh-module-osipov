using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking2
{
    public sealed class BankAccount : IDisposable
    {
        private long accNo;
        private decimal accBal;
        private BankAccountType accType;

        private static long nextAccNo = 123;

        private Queue tranQueue = new Queue();

        private bool disposed = false;

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

        // binary operators
        public static bool operator ==(BankAccount acc1, BankAccount acc2)
        {
            if ((acc1.accType == acc2.accType) &&
              (acc1.accNo == acc2.accNo) &&
              (acc1.accBal == acc2.accBal))
                return true;
            else
                return false;
        }
        public static bool operator !=(BankAccount acc1, BankAccount acc2)
        {
            return !(acc1 == acc2);
        }

        // object methods
        public override bool Equals(object acc1)
        {
            return this == (BankAccount)acc1;
        }
        public override string ToString()
        {
            string retVal = "Number: " + this.accNo + "\tType: ";
            retVal += (this.accType == BankAccountType.Checking) ? "Checking" : "Deposit";
            retVal += "\tBalance: " + this.accBal;
            return retVal;
        }
        public override int GetHashCode()
        {
            return (int)this.accNo;
        }

        //internal void Populate(decimal balance)
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

        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine("DEBUG calling Dispose for account number {0}", accNo);

                StreamWriter swFile = File.AppendText("transactions.txt"); // default out to \bin\Debug

                swFile.WriteLine("Account number is {0}", accNo);
                swFile.WriteLine("Account balance is {0}", accBal);
                swFile.WriteLine("Account type is {0}", accType);
                swFile.WriteLine("Transactions:");

                foreach (BankTransaction tran in tranQueue)
                {
                    swFile.WriteLine("Date/Time: {0}\tAmount:{1}", tran.When(), tran.Amount());
                }
                swFile.Close();
                disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        ~BankAccount()
        {
            Dispose();
        }
    }
}
