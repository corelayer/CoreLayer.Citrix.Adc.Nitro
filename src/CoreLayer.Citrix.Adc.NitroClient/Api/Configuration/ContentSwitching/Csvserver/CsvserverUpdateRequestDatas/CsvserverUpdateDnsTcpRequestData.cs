namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver.CsvserverUpdateRequestDatas
{
    public class CsvserverUpdateDnsTcpRequestData : CsvserverUpdateRequestData
    {
        public CsvserverUpdateDnsTcpRequestData(string csvServerName) : base(csvServerName)
        {
        }
        
        public string TcpProfileName { get; set; }
        public string DnsProfileName { get; set; }
    }
}