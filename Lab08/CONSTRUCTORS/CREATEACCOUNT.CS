
using System;

class CreateAccount
{
    // Test Harness
    static void Main() 
    {
        //BankAccount acc1 = new BankAccount();
        //BankAccount acc2 = new BankAccount(AccountType.Deposit);
        //BankAccount acc3 = new BankAccount(100);
        //BankAccount acc4 = new BankAccount(AccountType.Deposit, 500);

        //acc1.Deposit(250);
        //acc2.Deposit(100);
        //acc3.Withdraw(20);
        //acc4.Withdraw(120);

        //Write(acc1);
        //Write(acc2);
        //Write(acc3);
        //Write(acc4);

        using (BankAccount acc1 = new BankAccount())
        {
            acc1.Deposit(100);
            acc1.Withdraw(50);
            acc1.Deposit(75);
            acc1.Withdraw(50);
            acc1.Withdraw(30);
            acc1.Deposit(40);
            acc1.Deposit(200);
            acc1.Withdraw(250);
            acc1.Deposit(25);
            Write(acc1);
        }

    }
      
    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}",  acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());
        Console.WriteLine("Transaction");
        foreach (BankTransaction tran in acc.Transactions())
        {
            Console.WriteLine($"Date\\Time: {tran.When()},\tAmount: {tran.Amount()} ");
        }
        Console.WriteLine();
    }
}
