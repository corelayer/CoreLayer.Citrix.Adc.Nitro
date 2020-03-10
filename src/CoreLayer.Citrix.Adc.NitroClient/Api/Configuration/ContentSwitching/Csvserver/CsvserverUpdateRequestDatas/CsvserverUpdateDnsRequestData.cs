namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver.CsvserverUpdateRequestDatas
{
    public class CsvserverUpdateDnsRequestData : CsvserverUpdateRequestData
    {
        public CsvserverUpdateDnsRequestData(string csvServerName) : base(csvServerName)
        {
        }
        
        public string DnsProfileName { get; set; }
    }
}