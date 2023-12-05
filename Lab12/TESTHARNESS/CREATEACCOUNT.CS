
using System;
using System.Collections;
using Banking;

// Test harness
class CreateAccount
{
    static void Main() 
    {

		// Create two bank accounts. Use Bank.CreateAccount(...) with the same balance and type
		// Store the numbers of these two accounts in long variables accNo1 and accNo2
		long accNo1 = Bank.CreateAccount(AccountType.Checking, 100);
		long accNo2 = Bank.CreateAccount(AccountType.Checking, 100);

		// Create two BankAccount variables, acc1 and acc2. 
		// Use Bank.GetAccount() to populate them with the two accounts just created
		BankAccount acc1 = Bank.GetAccount(accNo1);
		BankAccount acc2 = Bank.GetAccount(accNo2);
        acc1.Holder = "Sid";
		acc2.Holder = "Ted";

        //Console.WriteLine($"Account Number is {acc1.Number}, Account Type is {acc1.Type}, Account Holder: {acc1.Holder}"); 
		//Console.WriteLine($"Account Number is {acc2.Number}, Account Type is {acc2.Type}, Account Holder: {acc2.Holder}");

		acc1.Deposit(101);
		acc2.Withdraw(15);


        Write(acc1);
        //Write(acc2);

        for (int i = 0; i < 5; i++)
        {
            acc1.Withdraw(20);
            acc1.Deposit(100);
        }
        Write(acc1);



    }
    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}", acc.Number);
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type);
        Console.WriteLine("Account Holder is {0}", acc.Holder);


        // Print out the transactions (if any)
        Console.WriteLine("Transactions");
        Queue tranQueue = acc.Transactions();
        for (int counter = 0; counter < tranQueue.Count; counter++)
        {
            BankTransaction tran = acc[counter];
            Console.WriteLine("Date: {0}\tAmount: {1}", tran.When, tran.Amount);
        }

        //foreach (BankTransaction tran in tranQueue)
        //{
        //    Console.WriteLine("Date: {0}\tAmount: {1}", tran.When, tran.Amount);
        //}
    }
}

