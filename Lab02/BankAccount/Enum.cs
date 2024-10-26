namespace BankAccount
{
    public enum AccountType { 
        Checking, 
        Deposit 
    }

    internal class Enum
    {
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;
            goldAccount.Equals(AccountType.Checking);

            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);
        }
    }
}
