using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public enum AccountType {Checking, Depostit}

    internal class Enum
    {
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType pltainumAccount;

            goldAccount = AccountType.Checking;
            pltainumAccount = AccountType.Depostit;

            Console.WriteLine($"The Customer Account Type is {goldAccount}.");
            Console.WriteLine($"The Customer Account Type is {pltainumAccount}.");
        }
    }
}
