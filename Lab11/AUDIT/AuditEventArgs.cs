using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    
    public class AuditEventArgs : EventArgs
    {
        private readonly BankTransaction transData = null;

        public AuditEventArgs(BankTransaction transaction)
        {
            transData = transaction;
        }

        public BankTransaction getTransaction()
        { 
            return transData;
        }
    }
}
