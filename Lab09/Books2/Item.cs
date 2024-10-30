using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books2
{
    internal class Item
    {
        protected long invNumber;

        protected bool taken;

        public bool IsAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }

        public long GetInvNumber()
        {
            return invNumber;
        }

        public void Take()
        {
            taken = false;
        }

        public void Return()
        {
            taken = true;
        }

        public void Show() // method conflict with derived class, could be virtual
        {
            Console.WriteLine("Status:\n Inventory Number: {0}\n Availability: {1}", invNumber, taken);
        }

    }
}
