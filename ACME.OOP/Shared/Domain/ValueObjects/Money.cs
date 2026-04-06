namespace oppsample.Shared.Domain.ValueObjects;

/// <summary>
/// Represent a monetary
/// </summary>

public record Money()
{
    public decimal Amount  { get; init; }
    public string Currency { get; init; }
    /// <summary>
    /// Creates a new instance of <see cref="Money"/>
    /// </summary>
    /// <param name="amount">the monetary amount </param>
    /// <param name="currency">The currency</param>
    /// <exception cref="ArgumentException">Thrown when the currency is not a valid letter 150 code</exception>
    public Money(decimal amount, string currency) 
    {
        if (string.IsNullOrWhiteSpace(currency) || currency.Length != 3)
            throw new ArgumentException("Currencies must be 3-letter code.", nameof(currency));
        Amount = amount;
        Currency = currency;
    }
    
    /// <summary>
    /// returns a string representation of the money, combining the assount and currency 
    /// </summary>
    /// <returns>string in the format 'Amount Currency' </returns>
    public override string ToString()=> $"{Amount} {Currency}";
/// <summary>
/// Adds twp <see cref="Money"/>objects
/// </summary>
/// <param name="other">the other <see cref="Money"/> to add, must have the same currency</param>
/// <returns>A new <see cref="Money"/> instance with the combined assount if the currencies match; otherview</returns>
    public Money Add(Money? other)
    {
        return other == null ? this : new Money(Amount + other.Amount, Currency);
    }
public Money Multiply(int multiplier) => new(Amount * multiplier, Currency);
}