using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen2
{
    class Account
    {
        public int Id { get; private set; } // номер счета
        public Account(int _id)
        {
            Id = _id;
        }
    }

   /* С помощью выражения where T : Account указываем, 
   что используемый тип T обязательно должен быть классом Account или его наследником.*/
    class Bank<T> where T : Account
    {
        T[] accounts;

        public Bank(T[] accs)
        {
            this.accounts = accs;
        }
        // вывод информации обо всех аккаунтах
        public void AccountsInfo()
        {
            foreach (Account acc in accounts)
            {
                Console.WriteLine(acc.Id);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[]
            { new Account(1857), new Account(2225), new Account(33232)  };

            Bank<Account> bank = new Bank<Account>(accounts);

            bank.AccountsInfo();

            Console.ReadLine();
        }
    }
}
