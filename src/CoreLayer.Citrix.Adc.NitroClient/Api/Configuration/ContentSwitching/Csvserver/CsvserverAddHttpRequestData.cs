using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverAddHttpRequestData : CsvserverAddRequestData
    {
        public CsvserverAddHttpRequestData(string csvserverName) : base(csvserverName){}
        public CsvserverAddHttpRequestData(string csvserverName, string ipAddress, int port) 
            : base(csvserverName, ipAddress, port){}
        public CsvserverAddHttpRequestData(string csvserver, string ipPattern, string ipMask, int port) 
            : base(csvserver, ipPattern, ipMask, port){}
        public override string ServiceType { get; } = "HTTP";
        
        public string Cacheable { get; set; } 
        public string RedirectUrl { get; set; } 
        public string RedirectPortRewrite { get; set; }
        [JsonPropertyName("insertvserveripport")]public string InsertVirtualServerIpPort { get; set; } 
        [JsonPropertyName("vipheader")]public string VirtualServerIpAndPortHeader { get; set; }
        public string AuthenticationHost { get; set; } 
        public string Authentication { get; set; }
        [JsonPropertyName("authn401")]public string AuthenticationWithHttp401 { get; set; }
        [JsonPropertyName("authnvsname")]public string AuthenticationVirtualServerName { get; set; }
        public string Push { get; set; }
        [JsonPropertyName("pushvserver")]public string PushVirtualServer { get; set; }
        public string PushLabel { get; set; }
        public string PushMulticlients { get; set; }
        public string TcpProfileName { get; set; }
        public string HttpProfileName { get; set; }
        [JsonPropertyName("authnprofile")]public string AuthenticationProfile { get; set; }
    }
}