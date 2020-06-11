namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverAddDnsTcpRequestData : CsvserverAddRequestData
    {
        public CsvserverAddDnsTcpRequestData(string csvserverName) : base(csvserverName){}
        public CsvserverAddDnsTcpRequestData(string csvserverName, string ipAddress, int port) 
            : base(csvserverName, ipAddress, port){}
        public CsvserverAddDnsTcpRequestData(string csvserver, string ipPattern, string ipMask, int port) 
            : base(csvserver, ipPattern, ipMask, port){}
        
        public override string ServiceType { get; } = "DNS_TCP";
        
        public string TcpProfileName { get; set; }
        public string DnsProfileName { get; set; }
        
    }
}