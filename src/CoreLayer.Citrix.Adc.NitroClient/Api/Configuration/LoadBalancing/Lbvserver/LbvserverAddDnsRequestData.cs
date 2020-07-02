using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverAddDnsRequestData : LbvserverAddRequestData
    {
        public LbvserverAddDnsRequestData(string lbvserverName) : base(lbvserverName)
        {
        }

        public override string ServiceType { get; } = "DNS";
        
        [JsonPropertyName("ipv46")]public string IpVersion4Or6Value { get; set; } 
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public int? Port { get; set; }
        public string PersistenceType { get; set; }
        public string Dns64 { get; set; }
        public string BypassAaaa { get; set; }
        public string RecursionAvailable { get; set; }
        public string DnsProfileName { get; set; }
    }
}