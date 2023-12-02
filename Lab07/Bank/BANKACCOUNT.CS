
class BankAccount 
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;

    private static long nextAccNo = 123;

    public void Populate(decimal accBalance)
    { 
        accNo = NextNumber();
        accBal = accBalance;
        accType = AccountType.Checking;
    }

    public long Number() => accNo;

    public decimal Balance() => accBal;

    public string Type() => accType.ToString();

    private static long NextNumber()
    { 
        return nextAccNo++;
    }

    public void Deposit(decimal cash)
    {
        if (cash > 0)
        {
            accBal += cash;
        }
        else
        {
            throw new ArgumentException("Нельзя вносить сумму меньше 0");
        }
    }

    public bool Withdraw(decimal cash)
    { 
        if (accBal < cash)
        {
            //Console.WriteLine("Недостаточно средств для выполнения опервации");
            return false;
        } 
        else
        { 
            accBal -= cash;
            //Console.WriteLine($"Баланс составляет {Balance()}");
            return true;
        }
    }

    public void TransferFrom(BankAccount accFrom, decimal amount)
    {
        if (accFrom.Withdraw(amount))
        {
            Deposit(amount);
        }
    }
}
