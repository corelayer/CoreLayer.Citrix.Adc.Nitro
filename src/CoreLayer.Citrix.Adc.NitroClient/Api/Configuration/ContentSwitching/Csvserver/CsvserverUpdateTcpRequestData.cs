namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverUpdateTcpRequestData : CsvserverUpdateRequestData
    {
        public CsvserverUpdateTcpRequestData(string csvServerName) : base(csvServerName)
        {
        }
        
        public string TcpProfileName { get; set; }
    }
}