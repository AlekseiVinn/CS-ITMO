using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Banking
{
    public class Audit
    {
        private string filename;
        private StreamWriter auditFile;
        private bool closed = false;

        public Audit(string fileToUse)
        { 
            filename = fileToUse;
            auditFile = File.AppendText(filename);
        }

        public void RecordTransaction(object sender, AuditEventArgs eventData)
        {
            BankTransaction tempTrans = eventData.getTransaction();
            if (tempTrans != null) 
            {
                auditFile.WriteLine($"Amount: {tempTrans.Amount()}\tDate: {tempTrans.When()}");
            }
        }

        public void Close()
        {
            if (!closed)
            { 
                auditFile.Close();
                closed = true;
            }
        }
    }
}
