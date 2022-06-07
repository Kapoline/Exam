using Exam.Calsulations;
using Exam.Models;
using Exam_Criminal;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ClientController : ControllerBase
{
    private readonly ClientCriminalChecker _criminalChecker;
    private readonly CreditScore _creditScore;
    private readonly CreditRate _creditRate;

    public ClientController(CreditScore creditScore, ClientCriminalChecker criminalChecker, CreditRate creditRate)
    {
        _creditScore = creditScore;
        _criminalChecker = criminalChecker;
        _creditRate = creditRate;
    }
    
    [HttpPost]
    public async Task<IActionResult> GetClient([FromBody] FormModel _model)
    {
        var clientStatus = await _criminalChecker.ClientIsCriminal(_model);
        if (clientStatus)
        {
            return new JsonResult(new CreditResult(null, false, "Lie", null));
        }

        var finalCredit = _creditScore.Credit(_model);

        if (finalCredit <= 80)
        {
            return new JsonResult(new CreditResult(finalCredit, false, "No", null));
        }

        var creditRate = _creditRate.CalculateRate(finalCredit);
        return new JsonResult(new CreditResult(finalCredit, true, "Yes", creditRate));

    }
}