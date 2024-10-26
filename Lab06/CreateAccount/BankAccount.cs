using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAccount
{
    internal class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;

        private static long nextAccNo = 123;

        public void Populate(decimal balance)
        {
            //accNo = number;
            accNo = NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
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
        //public AccountType Type()
        //{
        //    return accType;
        //}
        public string Type()
        {
            return accType.ToString();
        }
    }
}
