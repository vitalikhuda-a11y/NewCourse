using System;

public readonly struct Money
{
    public decimal Amount { get; }
    public string Currency { get; }
    public Money(decimal amount, string currency)
    {
        if (amount < 0) throw new ArgumentException("Amount can't be negative");
        Amount = amount;
        Currency = currency;
    }
    public Money Add(Money other)
    {
        if(Currency != other.Currency)
    throw new InvalidOperationException("Currency mismatch");

        return new Money(Amount + other.Amount, Currency);
    }
}