using Exam_Criminal;
using Exam.Models;

namespace Exam.Calsulations;

public class CriminalCalculation
{
    private readonly IsPersonIsCriminal _clientCriminal;
    
    public CriminalCalculation(IsPersonIsCriminal clientCriminal)
    {
        _clientCriminal = clientCriminal;
    }

    public async Task<bool> IsClientReallyCriminal(FormModel _model)
    {
        return await _clientCriminal.IsClientCriminal(_model.PassportNumber, _model.CriminalRecord);
    }
}