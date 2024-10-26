namespace MoreMethods
{
    internal class Program
    {
        enum AccountType
        {
            Checking,
            Deposit
        }

        class BankAccount
        {
            private long accNo;
            private decimal accBal;
            private AccountType accType;

            private static long nextAccNo = 123;

            public void Populate(decimal balance)
            {
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

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bank account");

            BankAccount berts = NewBankAccount();
            Write(berts);
            TestDeposit(berts);
            Write(berts);
            TestWithdraw(berts);
            Write(berts);

            BankAccount freds = NewBankAccount();
            Write(freds);
            TestDeposit(freds);
            Write(freds);
            TestWithdraw(freds);
            Write(freds);
        }

        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            Console.Write("Enter the account balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            created.Populate(balance);

            return created;
        }

        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());
        }

        static void TestDeposit(BankAccount toDeposit)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            toDeposit.Deposit(amount);
        }

        static void TestWithdraw(BankAccount acc)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (!acc.Withdraw(amount))
            {
                Console.WriteLine("Insufficient funds to withdraw.");
            }
        }

    }
}
