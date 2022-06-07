using Exam.Models;

namespace Exam.Calsulations;

public class CreditScore
{
    public int Credit(FormModel _model)
    {
        var (FullName, PassportSeries, PassportNumber, PassportGiven, PassportGivenDate, PassportRegistration, Age,
            CriminalRecord, Sum, Aim, Employment, OtherCredits, Pledge, carAge) = _model;
        
        var credit = 0;

        //Age
        credit += Age switch
        {
            >= 21 and <= 21 => Sum switch
            {
                < 100000 => 12,
                < 300000 => 9,
                _ => 0
            },
            >= 29 and <= 59 => 14,
            >= 69 and <= 72 => Pledge is not Pledge.NoPLedge ? 8 : 0,
            _ => 0
        };

        //Employment 
        credit += Employment switch
        {
            Employment.LaborContract => 14,
            Employment.OwnProduction => 12,
            Employment.Freelancer => 8,
            Employment.Pensioner => Age < 70 ? 5 : 0,
            Employment.Unemployed => 0,
            _ => throw new ArgumentOutOfRangeException()
        };
        //Aim
        credit += Aim switch
        {
            Aim.Consumer => 14,
            Aim.RealEstate => 8,
            Aim.OnLending => 12,
            _ => throw new ArgumentOutOfRangeException()
        };
        
        //Pledge
        credit += Pledge switch
        {
            Pledge.Estate => 14,
            Pledge.Car => carAge < 3 ? 8 : 3,
            Pledge.Quarentee => 12,
            Pledge.NoPLedge => 0,
            _ => throw new ArgumentOutOfRangeException()
        };
        
        //CriminalRecord
        if (CriminalRecord)
        {
            credit += 15;
        }
        
        //Other Credits
        credit += OtherCredits ? 0 : Aim is Aim.OnLending ? 0 : 15;
        
        //Sum
        credit += Sum switch
        {
            <= 1000000 => 12,
            <= 5000000 => 14,
            <= 10000000 => 8,
            _ => 0
        };
        return credit;
    }
    
}