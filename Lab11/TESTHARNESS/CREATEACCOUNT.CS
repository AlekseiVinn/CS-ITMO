
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

		// Create two BankAccount variables, acc1 and acc2. 
		// Use Bank.GetAccount() to populate them with the two accounts just created

		// Compare acc1 and acc2 using the == operator (should be false as the account numbers will be different)

		// Compare acc1 and acc2 using the != operator (should be true as the account numbers will be different)

		// Create a third BankAccount variable, acc3, and populate it with the account whose
		// account number is in accNo1. Use Bank.GetAccount()

		// Compare acc1 and acc3 using the == operator (should be true as all the data will be the same)

		// Compare acc1 and acc3 using the == operator (should be false)

		long acc1Num = Bank.CreateAccount(AccountType.Deposit, 1500);
		BankAccount acc1 = Bank.GetAccount(acc1Num);

        long acc2Num = Bank.CreateAccount(AccountType.Deposit, 1500);
        BankAccount acc2 = Bank.GetAccount(acc2Num);

        Console.WriteLine($"acc1 == acc2 ? -> {acc1 == acc2}");
        Console.WriteLine($"acc1 != acc2 ? -> {acc1 != acc2}");

        BankAccount acc3 = Bank.GetAccount(acc1Num);

        Console.WriteLine($"acc1 == acc3 ? -> {acc1 == acc3}");
        Console.WriteLine($"acc1 != acc3 ? -> {acc1 != acc3}");

        if (acc1.Equals(acc2))
        {
            Console.WriteLine("Both accounts are the same. They should not be!");
        }
        else
        {
            Console.WriteLine("The accounts are different. Good!");
        }
        if (!acc1.Equals(acc2))
        {
            Console.WriteLine("The accounts are different. Good!");
        }
        else
        {
            Console.WriteLine("Both accounts are the same. They should not be!");
        }
        if (acc1.Equals(acc3))
        {
            Console.WriteLine("The accounts are the same. Good!");
        }
        else
        {
            Console.WriteLine("The accounts are different. They should not be!");
        }
        if (!acc1.Equals(acc3))
        {
            Console.WriteLine("The accounts are different. They should not be!");
        }
        else
        {
            Console.WriteLine("The accounts are the same. Good!");
        }

        Console.WriteLine();
        Console.WriteLine(acc1);
        Console.WriteLine(acc2);
        Console.WriteLine(acc3);

        acc1.Dispose();
        acc2.Dispose(); 
        acc3.Dispose();

        Console.WriteLine(acc1);
    }
    
    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}",  acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());

		// Print out the transactions (if any)
		Console.WriteLine("Transactions");
		Queue tranQueue = acc.Transactions();
		foreach (BankTransaction tran in tranQueue) {
			Console.WriteLine("Date: {0}\tAmount: {1}", tran.When(), tran.Amount());
		}
    }
}
