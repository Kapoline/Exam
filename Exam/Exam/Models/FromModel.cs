using System.ComponentModel.DataAnnotations;

namespace Exam.Models;

public record FormModel(
    [Required] string FullName,
    [Required, Range(1000, 10000)]int PassportSeries,
    [Required, Range(100000, 1000000)]int PassportNumber,
    [Required] string PassportGiven,
    [Required]DateOnly PassportGivenDate,
    [Required] string PassportRegistration,
    [Required] int Age,
    bool CriminalRecord,
    [Required] decimal Sum,
    [Required] Aim Aim,
    [Required]Employment Employment,
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
    