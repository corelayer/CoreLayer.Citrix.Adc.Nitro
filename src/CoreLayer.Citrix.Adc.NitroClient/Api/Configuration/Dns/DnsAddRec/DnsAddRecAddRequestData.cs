using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsAddRec
{
    public class DnsAddRecAddRequestData : INitroRequestData
    {
        public DnsAddRecAddRequestData(string hostName, string Ip)
        {
            HostName = hostName;
            IpAddress = Ip;
        }
        public string HostName { get; }
        public string IpAddress { get; }
        [JsonPropertyName("ttl")]public double? TimeToLive { get; set; }
    }
}