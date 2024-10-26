using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CreateAccount
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

            BankAccount berts = NewBankAccount();
            Write(berts);

            BankAccount freds = NewBankAccount();
            Write(freds);
        }

        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            //Console.Write("Enter the account number: ");
            //long number = long.Parse(Console.ReadLine());

            //long number = BankAccount.NextNumber();

            Console.Write("Enter the account balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            //created.accNo = number;
            //created.accBal = balance;
            //created.accType = AccountType.Checking;

            //created.Populate(number, balance);
            created.Populate(balance);

            return created;
        }

        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());
        }
    }
}
