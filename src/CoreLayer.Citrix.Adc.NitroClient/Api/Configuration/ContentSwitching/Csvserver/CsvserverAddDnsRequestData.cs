namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverAddDnsRequestData : CsvserverAddRequestData
    {
        public CsvserverAddDnsRequestData(string csvserverName) : base(csvserverName){}
        public CsvserverAddDnsRequestData(string csvserverName, string ipAddress, int port) 
            : base(csvserverName, ipAddress, port){}
        public CsvserverAddDnsRequestData(string csvserverName, string ipPattern, string ipMask, int port) 
            : base(csvserverName, ipPattern, ipMask, port){}
        public override string ServiceType { get; } = "DNS";
        
        public string DnsProfileName { get; set; }
    }
}