namespace Exam.Calsulations;

public class CreditRate
{
    public decimal CalculateRate(int credit)
    {
        credit = credit switch
        {
            >= 100 => (int) 12.5m,
            >= 96 => 15,
            >= 92 => 19,
            >= 88 => 22,
            84 => 26,
            80 => 30,
            _ => throw new ArgumentException()
        };
        return credit;
    }
}