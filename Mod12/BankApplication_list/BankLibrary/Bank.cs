﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class Bank<T> where T : Account
    {
       // T[] accounts;
        List<T> accounts;
        public string Name { get; private set; }

        public Bank(string name)
        {
            this.Name = name;
        }
        // метод создания счета
        public void Open(AccountType accountType, decimal sum,
            AccountStateHandler addSumHandler, AccountStateHandler withdrawSumHandler,
            AccountStateHandler calculationHandler, AccountStateHandler closeAccountHandler,
            AccountStateHandler openAccountHandler)
        {
            T newAccount = null;

            switch (accountType)
            {
                case AccountType.Ordinary:
                    newAccount = new DemandAccount(sum, 1) as T;
                    break;
                case AccountType.Deposit:
                    newAccount = new DepositAccount(sum, 40) as T;
                    break;
            }

            if (newAccount == null)
                throw new Exception("Ошибка создания счета");
            // добавляем новый счет в массив счетов      
            if (accounts == null)
                accounts = new List<T> { newAccount };
            else
            {
                accounts.Add(newAccount);
                //T[] tempAccounts = new T[accounts.Length + 1];
                //for (int i = 0; i < accounts.Length; i++)
                //    tempAccounts[i] = accounts[i];
                //tempAccounts[tempAccounts.Length - 1] = newAccount;
                //accounts = tempAccounts;
            }
            // установка обработчиков событий счета
            newAccount.Added += addSumHandler;
            newAccount.Withdrawed += withdrawSumHandler;
            newAccount.Closed += closeAccountHandler;
            newAccount.Opened += openAccountHandler;
            newAccount.Calculated += calculationHandler;

            newAccount.OnOpened();
        }
        //добавление средств на счет
        public void Put(decimal sum, int id)
        {
            T account = FindAccount(id);
            if (account == null)
                throw new Exception("Счет не найден");
            account.Put(sum);
        }
        // вывод средств
        public void Withdraw(decimal sum, int id)
        {
            T account = FindAccount(id);
            if (account == null)
                throw new Exception("Счет не найден");
            account.Withdraw(sum);
        }
        // закрытие счета
        public void Close(int id)
        {
            int index;
            T account = FindAccount(id, out index);
            if (account == null)
                throw new Exception("Счет не найден");

            account.Close();

            if (accounts.Count <= 1)
                accounts = null;
            else
            {
                accounts.Remove(account);
                // уменьшаем массив счетов, удаляя из него закрытый счет
                //T[] tempAccounts = new T[accounts.Length - 1];
                //for (int i = 0; i < accounts.Length; i++)
                //{
                //    if (i == index)
                //        continue;
                //    tempAccounts[i] = accounts[i];
                //}
                //accounts = tempAccounts;
            }
        }

        // начисление процентов по счетам
        public void CalculatePercentage()
        {
            if (accounts == null) // если массив не создан, выходим из метода
                return;
            //for (int i = 0; i < accounts.Count; i++)
            //{
            //    T account = accounts[i];
            //    account.IncrementDays();
            //    account.Calculate();
            //}

            foreach (var item in accounts)
            {
                item.IncrementDays();
                item.Calculate();
            }
        }

        // поиск счета по id
        public T FindAccount(int id)
        {
            //for (int i = 0; i < accounts.Count; i++)
            //{
            //    if (accounts[i].Id == id)
            //        return accounts[i];
            //}

            foreach (var item in accounts)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }
        // перегруженная версия поиска счета
        public T FindAccount(int id, out int index)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Id == id)
                {
                    index = i;
                    return accounts[i];
                }
            }
            index = -1;
            return null;
        }
    }
    // тип счета
    public enum AccountType
    {
        Ordinary,
        Deposit
    }

}
