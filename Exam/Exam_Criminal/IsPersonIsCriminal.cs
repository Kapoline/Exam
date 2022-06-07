namespace Exam_Criminal;

public class IsPersonIsCriminal
{
    public async Task<bool> IsClientCriminal(int passportNumber, bool res)
    {
        return ((passportNumber % 3 == 0) == res);
    }
}