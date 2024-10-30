using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books2
{
    internal abstract class Item
    {
        protected long invNumber;

        protected bool taken;

        public Item()
        {
            this.taken = false; // corrected
        }

        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }

        public bool IsAvailable()
        {
            if (taken == true)
                return false; // corrected
            else
                return true;
        }

        public long GetInvNumber()
        {
            return invNumber;
        }

        public void Take()
        {
            taken = true; // corrected
        }
        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }

        public abstract void Return(); // now virtual, now abstract
        //{
        //    taken = false; // corrected
        //}

        public virtual void Show() // method conflict with derived class, could be virtual, now virtual
        {
            Console.WriteLine("Status:\n Inventory Number: {0}\n Availability: {1}", invNumber, (!taken)); // corrected
        }

    }
}
