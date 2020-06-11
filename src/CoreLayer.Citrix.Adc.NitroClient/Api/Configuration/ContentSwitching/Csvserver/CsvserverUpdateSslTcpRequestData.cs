namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverUpdateSslTcpRequestData : CsvserverUpdateRequestData
    {
        public CsvserverUpdateSslTcpRequestData(string csvServerName) : base(csvServerName)
        {
        }
        
        public string TcpProfileName { get; set; }
    }
}