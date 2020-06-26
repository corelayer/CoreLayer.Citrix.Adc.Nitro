using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsNsRec
{
    public class DnsNsRecAddRequestData : INitroRequestData
    {
        public DnsNsRecAddRequestData(string domain, string nameServer)
        {
            Domain = domain;
            NameServer = nameServer;
        }
        public string Domain { get; }
        public string NameServer { get;}
        [JsonPropertyName("ttl")]public double? TimeToLive { get; set; }
    }
}