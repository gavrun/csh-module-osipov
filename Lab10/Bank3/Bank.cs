using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank3
{
    internal class Bank
    {
        private static Hashtable accounts = new Hashtable();

        private Bank()
        {
        }

        //public BankAccount CreateAccount()
        //{
        //    return new BankAccount();
        //}
        public static long CreateAccount()
        {
            BankAccount newAcc = new BankAccount();
            long accNo = newAcc.Number();
            accounts[accNo] = newAcc;
            return accNo;
        }

        // more
        public static long CreateAccount(BankAccountType aType, decimal aBal)
        {
            BankAccount newAcc = new BankAccount(aType, aBal);
            long accNo = newAcc.Number();
            accounts[accNo] = newAcc;
            return accNo;
        }

        public static long CreateAccount(BankAccountType aType)
        {
            BankAccount newAcc = new BankAccount(aType);
            long accNo = newAcc.Number();
            accounts[accNo] = newAcc;
            return accNo;
        }

        public static long CreateAccount(decimal aBal)
        {
            BankAccount newAcc = new BankAccount(aBal);
            long accNo = newAcc.Number();
            accounts[accNo] = newAcc;
            return accNo;
        }

        // more
        public static bool CloseAccount(long accNo)
        {
            BankAccount closing = (BankAccount)accounts[accNo];
            
            if (closing != null)
            {
                accounts.Remove(accNo);
                closing.Dispose();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static BankAccount GetAccount(long accNo)
        {
            return (BankAccount)accounts[accNo];
        }
    }
}