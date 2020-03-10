namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver.CsvserverAddRequestDatas
{
    public class CsvserverAddUdpRequestData : CsvserverAddRequestData
    {
        public CsvserverAddUdpRequestData(string csvserverName) : base(csvserverName){}
        public CsvserverAddUdpRequestData(string csvserverName, string ipAddress, int port) 
            : base(csvserverName, ipAddress, port){}
        public CsvserverAddUdpRequestData(string csvserver, string ipPattern, string ipMask, int port) 
            : base(csvserver, ipPattern, ipMask, port){}
        public override string ServiceType { get; } = "UDP";
    }
}