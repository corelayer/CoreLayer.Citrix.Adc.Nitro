namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverUpdateDnsRequestData : CsvserverUpdateRequestData
    {
        public CsvserverUpdateDnsRequestData(string csvServerName) : base(csvServerName)
        {
        }
        
        public string DnsProfileName { get; set; }
    }
}