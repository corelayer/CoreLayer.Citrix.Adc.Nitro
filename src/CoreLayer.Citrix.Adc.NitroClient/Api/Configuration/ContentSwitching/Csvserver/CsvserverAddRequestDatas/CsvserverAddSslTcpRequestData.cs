namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver.CsvserverAddRequestDatas
{
    public class CsvserverAddSslTcpRequestData : CsvserverAddRequestData
    {
        public CsvserverAddSslTcpRequestData(string csvserverName) : base(csvserverName){}
        public CsvserverAddSslTcpRequestData(string csvserverName, string ipAddress, int port) 
            : base(csvserverName, ipAddress, port){}
        public CsvserverAddSslTcpRequestData(string csvserver, string ipPattern, string ipMask, int port) 
            : base(csvserver, ipPattern, ipMask, port){}
        public override string ServiceType { get; } = "SSL_TCP";
        
        public string TcpProfileName { get; set; }
    }
}