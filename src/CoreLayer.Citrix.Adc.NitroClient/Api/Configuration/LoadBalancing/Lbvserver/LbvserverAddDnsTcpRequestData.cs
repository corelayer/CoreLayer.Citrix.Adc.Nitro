using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverAddDnsTcpRequestData : LbvserverAddRequestData
    {
        public LbvserverAddDnsTcpRequestData(string lbvserverName) : base(lbvserverName)
        {
        }

        public override string ServiceType { get; } = "DNS_TCP";
        
        [JsonPropertyName("ipv46")]public string IpVersion4Or6Value { get; set; } 
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public int? Port { get; set; }
        public string PersistenceType { get; set; }
        public double? DataLength { get; set; }
        public double? DataOffset { get; set; }
        public string TcpProfileName { get; set; }
        public string Dns64 { get; set; }
        public string BypassAaaa { get; set; }
        public string RecursionAvailable { get; set; }
        public string DnsProfileName { get; set; }
    }
}