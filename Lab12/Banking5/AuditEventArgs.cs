using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking5
{
    public class AuditEventArgs : System.EventArgs
    {
        private readonly BankTransaction transData = null;

        // new default ctor
        public AuditEventArgs(BankTransaction transaction)
        {
            this.transData = transaction;
        }

        public BankTransaction getTransaction()
        {
            return this.transData;
        }
    }
}
