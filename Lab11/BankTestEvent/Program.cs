using Banking3;

namespace BankTestEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create two bank accounts
            long accNo1 = Bank.CreateAccount(200);
            long accNo2 = Bank.CreateAccount(100);

            BankAccount acc1 = Bank.GetAccount(accNo1);
            BankAccount acc2 = Bank.GetAccount(accNo2);

            // create audit trails for each account
            acc1.AuditTrail("audit_account_1.txt");
            acc2.AuditTrail("audit_account_2.txt");

            // generate events
            acc1.Deposit(100);
            acc1.Withdraw(50);
            acc1.Withdraw(100);
            acc1.Deposit(25);
            acc2.Withdraw(75);
            acc2.Deposit(100);
            acc2.Withdraw(35);
            acc2.Deposit(10);
            acc2.Deposit(50);

            // close bank accounts
            Bank.CloseAccount(accNo1);
            Bank.CloseAccount(accNo2);
        }
    }
}
