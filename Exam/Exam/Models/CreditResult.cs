namespace Exam.Models;

public record CreditResult(
    int? Score,
    bool Result,
    string Message,
    decimal? CreditRate);