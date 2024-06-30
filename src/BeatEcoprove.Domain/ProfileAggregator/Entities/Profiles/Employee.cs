using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;

public class Employee : Profile
{
    private Employee() { }

    private Employee(
        UserName userName, 
        Phone phone, 
        double xP, 
        int sustainabilityPoints, 
        int ecoScore, 
        UserType type) : base(userName, phone, xP, sustainabilityPoints, ecoScore, type)
    {
    }
}