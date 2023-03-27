using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using Payeer.Trade.Api.Domain.Data;
using Payeer.Trade.Api.Models.General;

namespace Payeer.Trade.Api.Domain;

public static class SignBuilder
{
    public static long Timestamp => new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds();
    public static async Task<SignatureInfo> BuildSignAsync(string apiSecret, string apiMethod, List<Parameter> parameters)
    {
        SignatureInfo signInfo = new()
        {
            Timestamp = Timestamp,
        };
        parameters.Add(new("ts", signInfo.Timestamp));
        var jsonData = parameters.ConvertToJson();

        var data = apiMethod + jsonData;

        signInfo.JsonData = jsonData;
        signInfo.Signature = await GetHmacSHA256(apiSecret, data);

        return signInfo;
    }
    private static async Task<string> GetHmacSHA256(string key, string data)
    {
        string hash;
        ASCIIEncoding encoder = new ASCIIEncoding();
        byte[] code = encoder.GetBytes(key);
        using (HMACSHA256 hmac = new HMACSHA256(code))
        {
            using (var ms = new MemoryStream(encoder.GetBytes(data)))
            {
                byte[] hmBytes = await hmac.ComputeHashAsync(ms);
                hash = ToHexString(hmBytes);
            }
        }
        return hash;
    }
    private static string ToHexString(byte[] array)
    {
        StringBuilder hex = new StringBuilder(array.Length * 2);
        foreach (byte b in array)
        {
            hex.AppendFormat("{0:x2}", b);
        }
        return hex.ToString();
    }
}