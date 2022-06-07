namespace Exam.Models;

public record FormModel(
    string FullName,
    int PassportSeries,
    int PassportNumber,
    string PassportGiven,
    DateOnly PassportGivenDate,
    string PassportRegistration,
    int Age,
    bool CriminalRecord,
    decimal Sum,
    Aim Aim,
    Employment Employment,
    bool OtherCredits,
    Pledge Pledge,
    int CarAge );

public enum Aim
{
    Consumer = 1,
    RealEstate = 2,
    OnLending = 3,
}

public enum Employment
{
    LaborContract = 1,
    OwnProduction = 2,
    Freelancer = 3,
    Pensioner = 4,
    Unemployed = 5
}

public enum Pledge
{
    Estate = 1,
    Car = 2,
    Quarentee = 3,
    NoPLedge = 4
}
    