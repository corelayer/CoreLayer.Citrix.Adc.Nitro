using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public class CsvserverUpdateSslRequestData : CsvserverUpdateRequestData
    {
        public CsvserverUpdateSslRequestData(string csvServerName) : base(csvServerName)
        {
        }
        
        public string Cacheable { get; set; } 
        public string RedirectUrl { get; set; } 
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