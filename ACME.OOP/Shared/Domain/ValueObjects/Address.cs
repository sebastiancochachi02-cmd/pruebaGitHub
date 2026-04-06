namespace oppsample.Shared.Domain.ValueObjects;
/// <summary>
/// Represent an international physical address value object
/// </summary>  
public record Address
{
    public string Street;
    public string Number;
    public string City;
    public string StateOrRegion;
    public string PostalCode;
    public  string Country;
/// <summary>
/// Creates a new instance of <see cref="Address"/>
/// </summary>
/// <param name="street">the address street, which must not be null r blank</param>
/// <param name="number">the number, which must not be null r blank</param>
/// <param name="city">the city, which must not be null r blank</param>
/// <param name="stateOrRegion">the stateOrRegion, which must not be state or region</param>
/// <param name="postalCode">the PostalCode, which must not be null r blank</param>
/// <param name="country">the country, which must not be null r blank</param>
/// <exception cref="ArgumentException">the ArgumentException, which must not be null r blank</exception>
    public Address(string street, string number, string city, string stateOrRegion, string postalCode, string country)
    {
        if (string.IsNullOrWhiteSpace(Street)) throw  new ArgumentException("Street cannot be null or empty");
        if (string.IsNullOrWhiteSpace(Number)) throw  new ArgumentException("Number cannot be null or empty");
        if (string.IsNullOrWhiteSpace(City)) throw  new ArgumentException("City cannot be null or empty");
        if (string.IsNullOrWhiteSpace(PostalCode)) throw  new ArgumentException("Postal code cannot be null or empty");
        if (string.IsNullOrWhiteSpace(Country)) throw  new ArgumentException("Country cannot be null or empty");
        
        Street = street;
        Number = number;
        City = city;
        StateOrRegion = stateOrRegion;
        PostalCode = postalCode;
        Country = country;
    }
/// <summary>
/// Returns the string representation of the address in the format:
/// </summary>
/// <returns></returns>
    public override string ToString()=> $"{Street}, {Number}, {City}, {StateOrRegion}, {PostalCode}, {Country}";
    }