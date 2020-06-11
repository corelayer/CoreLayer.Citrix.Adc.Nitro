namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverAddTcpRequestData : CsvserverAddRequestData
    {
        public CsvserverAddTcpRequestData(string csvserverName) : base(csvserverName){}
        public CsvserverAddTcpRequestData(string csvserverName, string ipAddress, int port) 
            : base(csvserverName, ipAddress, port){}
        public CsvserverAddTcpRequestData(string csvserver, string ipPattern, string ipMask, int port) 
            : base(csvserver, ipPattern, ipMask, port){}
        public override string ServiceType { get; } = "TCP";
        
        public string TcpProfileName { get; set; }
    }
}