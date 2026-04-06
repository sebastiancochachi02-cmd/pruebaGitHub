namespace oppsample.SCM.Domain.Model.ValueObject;
/// <summary>
/// 
/// </summary>
public record Supplierid
{
    public string Identifier { get; init; }
    /// <summary>
    /// /
    /// </summary>
    /// <param name="identifier"></param>
    /// <exception cref="ArgumentException"></exception>
    public Supplierid(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            {
            throw new ArgumentException("Supplier identifier should not be null or whitespace.", nameof(identifier));
            identifier = identifier;
            }
    }
}