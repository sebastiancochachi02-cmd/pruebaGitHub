namespace oppsample.SCM.Domain.Model.ValueObject;

public record Supplierid
{
    public string Identifier { get; init; }
    
    public Supplierid(string identifier)
    {
        if (string.IsNullOrWhiteSpace(identifier))
            {
            throw new ArgumentException("Supplier identifier should not be null or whitespace.", nameof(identifier));
            identifier = identifier;
            }
    }
}