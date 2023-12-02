using System;
using System.Collections;
using System.IO;

class BankAccount : IDisposable
{
	private long accNo;
    private decimal accBal;
    private AccountType accType;
    private bool disposed = false;
    
    private static long nextNumber = 123;
    private Queue tranQueue = new Queue();

    public BankAccount()
    {
        accNo = NextNumber();
        accBal = 0;
        accType = AccountType.Checking;
    }

    public BankAccount(AccountType aType)
    {
        accNo = NextNumber();
        accBal = 0;
        accType = aType;
    }

    public BankAccount(decimal aBal)
    {
        accNo = NextNumber();
        accBal = aBal;
        accType = AccountType.Checking;
    }

    public BankAccount(AccountType aType, decimal aBal)
    {
        accNo = NextNumber();
        accBal = aBal;
        accType = aType;
    }

    ~BankAccount() 
    {
        Dispose();
    }

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds) 
        {
            accBal -= amount;
            BankTransaction transaction = new BankTransaction(amount);
            tranQueue.Enqueue(transaction);
        }
        return sufficientFunds;
    }
    
    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        BankTransaction transaction = new BankTransaction(amount);
        tranQueue.Enqueue(transaction);
        return accBal;
    }
    
    public long Number()
    {
        return accNo;
    }
    
    public decimal Balance()
    {
        return accBal;
    }
    
    public string Type()
    {
        return accType.ToString();
    }

    private static long NextNumber()
    {
        return nextNumber++;
    }

    public Queue Transactions()
    { 
        return tranQueue;
    }

    public void Dispose()
    {
        if (!disposed)
        {
            StreamWriter swFile = File.AppendText("Transactions.Dat");
            swFile.WriteLine("Account number is {0}", accNo);
            swFile.WriteLine("Account balance is {0}", accBal);
            swFile.WriteLine("Account type is {0}", accType);
            swFile.WriteLine("Transactions:");
            foreach (BankTransaction trans in tranQueue)
            {
                swFile.WriteLine($"Date\\Time: {trans.When()},\tAmount: {trans.Amount()} ");
            }
            swFile.Close();
            disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
