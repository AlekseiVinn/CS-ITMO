using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructType
{
    public enum AccountType {Checking, Deposit}

    public struct BankAccount 
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
    
    internal class Struct
    {
        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            //goldAccount.accNo = 123;
            Console.Write("Enter account number: ");
            goldAccount.accNo = long.Parse(Console.ReadLine());
            
            Console.WriteLine(
                $"Account Number \t{goldAccount.accNo}\n"+
                $"Account Type \t{goldAccount.accType}\n"+
                $"Account Balance\t${goldAccount.accBal}");
        }
    }
}
