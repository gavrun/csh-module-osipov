using Banking3;

namespace BankTestAudit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create audit 
            Audit testAudit = new Audit("audit.txt");
            // create transaction
            BankTransaction testTran = new BankTransaction(500);
            // create transaction argument
            AuditEventArgs testArg = new AuditEventArgs(testTran);
            // log transaction
            testAudit.RecordTransaction(null, testArg);

            BankTransaction testTran2 = new BankTransaction(-200);
            AuditEventArgs testArg2 = new AuditEventArgs(testTran2);
            testAudit.RecordTransaction(null, testArg2);

            testAudit.Close();
        }
    }
}
