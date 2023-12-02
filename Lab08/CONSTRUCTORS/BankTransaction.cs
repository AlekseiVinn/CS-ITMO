using System;

public class BankTransaction
{
    private readonly DateTime when;
    private readonly decimal amount;

    public decimal Amount() => amount;

    public DateTime When() => when;

    public BankTransaction(decimal amount)
    { 
        this.amount = amount;
        when = DateTime.Now;
    }


}

