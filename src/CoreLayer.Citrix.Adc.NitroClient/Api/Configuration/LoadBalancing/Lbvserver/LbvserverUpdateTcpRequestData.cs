using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverUpdateTcpRequestData : LbvserverUpdateRequestData
    {
        public LbvserverUpdateTcpRequestData(string lbvserverName) : base(lbvserverName)
        {
        }
        
        [JsonPropertyName("ipv46")]public string IpVersion4Or6Value { get; set; }
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public string PersistenceType { get; set; }
        public double? DataLength { get; set; }
        public double? DataOffset { get; set; }
        public string TcpProfileName { get; set; }
    }
}