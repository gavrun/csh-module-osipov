using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking5
{
    public class BankTransaction
    {
        private readonly decimal amount;
        private readonly DateTime when;

        public decimal Amount
        {
            get { return amount; }
        }
        public DateTime When
        {
            get { return when; }
        }


        public BankTransaction(decimal tranAmount)
        {
            amount = tranAmount;
            when = DateTime.Now;
        }

        //public decimal Amount()
        //{
        //    return amount;
        //}
        //public DateTime When()
        //{
        //    return when;
        //}
    }
}
