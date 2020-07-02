using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverUpdateHttpRequestData : LbvserverUpdateRequestData
    {
        public LbvserverUpdateHttpRequestData(string lbvserverName) : base(lbvserverName)
        {
        }
        
        [JsonPropertyName("ipv46")]public string IpVersion4Or6Value { get; set; } 
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public string PersistenceType { get; set; }
        [JsonPropertyName("redirurl")]public string RedirectUrl { get; set; }
        public string Cacheable { get; set; }
        public string RedirectPortRewrite { get; set; }
        [JsonPropertyName("insertvserveripport")]public string InsertVirtualServerIpPort { get; set; }
        [JsonPropertyName("vipheader")]public string VirtualServerIpAndPortHeader { get; set; }
        public string AuthenticationHost { get; set; }
        public string Authentication { get; set; } 
        [JsonPropertyName("authn401")]public string AuthenticationWithHttp401 { get; set; }
        [JsonPropertyName("authnvsname")]public string AuthenticationVirtualServerName { get; set; }
        public string TcpProfileName { get; set; }
        public string HttpProfileName { get; set; }
        [JsonPropertyName("authnprofile")]public string AuthenticationProfile { get; set; }
    }
}