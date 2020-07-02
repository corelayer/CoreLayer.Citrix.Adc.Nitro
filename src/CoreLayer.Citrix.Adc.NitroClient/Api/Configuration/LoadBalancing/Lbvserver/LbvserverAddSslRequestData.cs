using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverAddSslRequestData : LbvserverAddRequestData
    {
        public LbvserverAddSslRequestData(string lbvserverName) : base(lbvserverName)
        {
        }

        public override string ServiceType { get; } = "SSL";
        
        [JsonPropertyName("ipv46")]public string IpVersion4Or6Value { get; set; } 
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public int? Port { get; set; }
        public string PersistenceType { get; set; }
        [JsonPropertyName("redirurl")]public string RedirectUrl { get; set; }
        public string Cacheable { get; set; }
        [JsonPropertyName("insertvserveripport")]public string InsertVirtualServerIpPort { get; set; }
        [JsonPropertyName("vipheader")]public string VirtualServerIpAndPortHeader { get; set; }
        public string AuthenticationHost { get; set; }
        public string Authentication { get; set; } 
        [JsonPropertyName("authn401")]public string AuthenticationWithHttp401 { get; set; }
        [JsonPropertyName("authnvsname")]public string AuthenticationVirtualServerName { get; set; }
        public string TcpProfileName { get; set; }
        public string HttpProfileName { get; set; }
        [JsonPropertyName("authnprofile")]public string AuthenticationProfile { get; set; }
        public int? RedirectFromPort { get; set; }
        public string HttpsRedirectUrl { get; set; }
    }
}