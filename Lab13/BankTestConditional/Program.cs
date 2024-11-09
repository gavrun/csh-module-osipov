#define DEBUG_ACCOUNT

using System;
using System.Collections;
using Banking7;

namespace BankTestConditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // сreate bank account and test 
            long accNo1 = Bank.CreateAccount(BankAccountType.Checking, 100);
            BankAccount myAccount = Bank.GetAccount(accNo1);


            // add a call
            myAccount.DumpToScreen();
        }
    }
}
