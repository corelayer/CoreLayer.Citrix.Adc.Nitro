namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverAddSslRequestData : CsvserverAddRequestData
    {
        public CsvserverAddSslRequestData(string csvserverName) : base(csvserverName){}
        public CsvserverAddSslRequestData(string csvserverName, string ipAddress, int port) 
            : base(csvserverName, ipAddress, port){}
        public CsvserverAddSslRequestData(string csvserver, string ipPattern, string ipMask, int port) 
            : base(csvserver, ipPattern, ipMask, port){}
        public override string ServiceType { get; } = "SSL";
        
        public string Cacheable { get; set; } 
        public string RedirectUrl { get; set; } 
        public string InsertVserverIpPort { get; set; } 
        public string VipHeader { get; set; }
        public string AuthenticationHost { get; set; } 
        public string Authentication { get; set; }
        public string Authn401 { get; set; }
        public string AuthnVsName { get; set; }
        public string Push { get; set; }
        public string PushVserver { get; set; }
        public string PushLabel { get; set; }
        public string PushMulticlients { get; set; }
        public string TcpProfileName { get; set; }
        public string HttpProfileName { get; set; }
        public string AuthnProfile { get; set; }
    }
}