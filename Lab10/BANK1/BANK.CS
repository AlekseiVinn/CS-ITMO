
using System.Collections;

public class Bank
{
    private static Hashtable accounts = new Hashtable();

    private Bank() { }

    public static long CreateAccount()
    {
        BankAccount acc =  new BankAccount();
        accounts.Add(acc.Number(), acc);
        return acc.Number();
    }

    public static long CreateAccount(AccountType accType, decimal accBal)
    {
        BankAccount acc = new BankAccount(accType, accBal);
        accounts.Add(acc.Number(), acc);
        return acc.Number();
    }

    public static long CreateAccount(AccountType accType)
    {
        BankAccount acc = new BankAccount(accType);
        accounts.Add(acc.Number(), acc);
        return acc.Number();
    }

    public static long CreateAccount(decimal accBal)
    {
        BankAccount acc = new BankAccount(accBal);
        accounts.Add(acc.Number(), acc);
        return acc.Number();
    }

    public static BankAccount GetAccount(long accNum)
    { 
        BankAccount account = (BankAccount)accounts[accNum];
        if (account != null)
        { 
            return account;
        } else 
        {
            return null; 
        } 
        
    }

    public static bool CloseAccount(long accNum)
    { 
        BankAccount accClose = (BankAccount)accounts[accNum];
        if (accClose != null) 
        {
            accounts.Remove(accNum);
            accClose.Dispose();
            return true;
        }
        else
        {
            return false;
        }
    }
}
