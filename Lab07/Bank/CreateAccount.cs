﻿using System.Threading.Channels;

class CreateAccount
{
    static void Main()
    {
        BankAccount berts = NewBankAccount();
        Write(berts);
        TestDeposit(berts);
        Write(berts);
        TestWithdraw(berts);
        Write(berts);

        BankAccount freds = NewBankAccount();
        Write(freds);
        TestDeposit(freds);
        Write(freds);
        TestWithdraw(freds);
        Write(freds);
    }

    static BankAccount NewBankAccount()
    {
        BankAccount created = new BankAccount();

        //Console.Write("Enter the account number   : ");
        //long number = long.Parse(Console.ReadLine());
        //long number = BankAccount.NextNumber();

        Console.Write("Enter the account balance : ");
        decimal balance = decimal.Parse(Console.ReadLine());

        created.Populate(balance);
        //created.accNo = number;
        //created.accBal = balance;
        //created.accType = AccountType.Checking;

        return created;
    }

    internal static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}", acc.Number());
        Console.WriteLine("Account balance is {0} $", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());
    }

    static void TestDeposit(BankAccount acc)
    {
        Console.WriteLine("Enter amount to deposit: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        acc.Deposit(amount);
    }

    static void TestWithdraw(BankAccount acc)
    {
        Console.WriteLine("Enter amount to withdraw: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        if (!acc.Withdraw(amount))
        {
            Console.WriteLine("Недостаточно средств");
        }
    }
}
