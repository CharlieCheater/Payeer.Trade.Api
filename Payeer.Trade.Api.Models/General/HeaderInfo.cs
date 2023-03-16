namespace Payeer.Trade.Api.Models.General
{
    public class HeaderInfo
    {
        public HeaderInfo(string key, string value)
        {
            Key = key;
            Value = value;
        }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
