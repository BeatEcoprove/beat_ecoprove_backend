using BeatEcoprove.Domain.Shared.Models;
using ErrorOr;

namespace BeatEcoprove.Domain.UserAggregator.ValueObjects;

public class Address : ValueObject
{
    private Address(string street, int port, string locality, PostalCode postalCode)
    {
        Street = street;
        Port = port;
        Locality = locality;
        PostalCode = postalCode;
    }
    
    public string Street { get; private set; }
    public int Port { get; private set; }
    public string Locality { get; private set; }
    public PostalCode PostalCode { get; private set; }
    
    public static ErrorOr<Address> Create(string street, int port, string locality, PostalCode postalCode)
    {
        return new Address(street, port, locality, postalCode);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Street;
        yield return Port;
        yield return Locality;
        yield return PostalCode;
    }

    public override string ToString()
    {
        return $"{Street}, {Port}, {Locality}, {PostalCode}";
    }

    public static implicit operator string(Address address) => address.ToString();
}