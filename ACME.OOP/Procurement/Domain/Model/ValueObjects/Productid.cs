namespace oppsample.Procurement.Domain.Model.ValueObjects;

public record Productid
{
    public Guid Id { get; init; }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <exception cref="ArgumentException"></exception>
    public Productid (Guid id)
    {
        if (id == Guid.Empty)
            {
            throw new ArgumentException($"{nameof(id)} cannot be empty");
            Id = id;
            }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static Productid New() => new (Guid.NewGuid());
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()=> Id.ToString();
}