internal class Test
{
    static void Main()
    { 
        BankAccount account1 = new BankAccount();
        account1.Populate(100);
        CreateAccount.Write(account1);
        
        Console.WriteLine();

        BankAccount account2 = new BankAccount();
        account2.Populate(100);
        CreateAccount.Write(account2);
        
        Console.WriteLine($"\nTransfer 10$ to №{account1.Number()} from №{account2.Number()}.....\n");
        account1.TransferFrom(account2, 10);
        CreateAccount.Write(account1);
        Console.WriteLine();
        CreateAccount.Write(account2);

    }
}
