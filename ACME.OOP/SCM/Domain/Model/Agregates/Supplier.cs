using oppsample.SCM.Domain.Model.ValueObject;
using oppsample.Shared.Domain.ValueObjects;

namespace oppsample.SCM.Domain.Model.Agregates;

public class Supplier(string indentifier, string name, Address address)
{
    public string Identifier = identifier ?? throw new ArgumentNullException(nameof(identifier));
    public string Name = name ?? throw new ArgumentNullException(nameof(name));
    public Address Address = address ?? throw new ArgumentNullException(nameof(address));
}