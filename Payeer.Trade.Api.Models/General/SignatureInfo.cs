namespace Payeer.Trade.Api.Models.General;

public class SignatureInfo
{
    public long Timestamp { get; set; }
    public string JsonData { get; set; }
    public string Signature { get; set; }
}