using Banking4;

namespace BankTestProp
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

            // set users
            acc1.Holder = "Sid";
            acc2.Holder = "Ted";

            // call for properties
            Console.WriteLine("Account Number is {0}, Account Type is {1}", acc1.Number, acc1.Type);
            Console.WriteLine("Account Number is {0}, Account Type is {1}", acc2.Number, acc2.Type);

            // my string format
            Console.WriteLine("acc1 - {0}", acc1);
            Console.WriteLine("acc2 - {0}", acc2);
        }
    }
}
