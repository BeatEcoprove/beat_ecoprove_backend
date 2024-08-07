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
        Type = UserType.Employee;
    }

    public static Employee Create(
         UserName userName,
         Phone phone
    )
    {
        return new Employee(
            userName,
            phone,
            0D,
            0,
            0,
            UserType.Employee
        );
    }
}