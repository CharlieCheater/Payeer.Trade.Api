namespace Payeer.Trade.Api.Models.Base;

public class ResultBase
{
    public bool Success { get; set; }
    public ErrorResult Error { get; set; }
}