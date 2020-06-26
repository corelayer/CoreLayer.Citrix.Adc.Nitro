using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAaaaRec
{
    public class DnsAaaaRecAddRequestData : INitroRequestData
    {
        public DnsAaaaRecAddRequestData(string hostName, string ipV6Address)
        {
            HostName = hostName;
            IpV6Address = ipV6Address;
        }
        public string HostName { get; }
        public string IpV6Address { get; }
        [JsonPropertyName("ttl")]public double? TimeToLive { get; set; }
    }
}