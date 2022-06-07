using Exam.Models;
using Exam_Criminal;

namespace Exam.Calsulations;

public class ClientCriminalChecker
{
    private readonly IsPersonIsCriminal _personIsCriminal;

    public ClientCriminalChecker(IsPersonIsCriminal personIsCriminal)
    {
        _personIsCriminal = personIsCriminal;
    }

    public async Task<bool> ClientIsCriminal(FormModel _model)
    {
        return await _personIsCriminal.IsClientCriminal(_model.PassportNumber, _model.CriminalRecord);
    }
}