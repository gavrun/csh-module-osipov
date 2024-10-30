using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books2
{
    internal class Magazine : Item, IPubs

    {
        private string volume;
        private int number;
        private string title;
        private int year;

        public bool IfSubs { get; set; }

        public Magazine()
        { }

        public Magazine(String volume, int number, String title, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

        public override void Show() // of virtual
        {
            Console.WriteLine("\nMagazine:\n Volume: {0}\n Issue: {1}\n Title: {2}\n Year: {3}", volume, number, title, year);
            base.Show();
        }

        //public void TakeItem()
        //{
        //    if (this.IsAvailable())
        //        this.Take();
        //}

        public override void Return() // implement virtual method
        {
            taken = false;
        }

        public void Subs()
        {
            Console.WriteLine("Subscription to magazine \"{0}\": {1}.", title, IfSubs);
        }
    }
}
