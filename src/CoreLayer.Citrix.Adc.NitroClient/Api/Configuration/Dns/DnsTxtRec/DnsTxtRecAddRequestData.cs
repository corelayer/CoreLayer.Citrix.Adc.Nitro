using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsTxtRec
{
    public class DnsTxtRecAddRequestData : INitroRequestData
    {
        public DnsTxtRecAddRequestData(string domain, string[] strings)
        {
            String = strings;
            Domain = domain;
        }
        public string Domain { get; }
        public string[] String { get; }
        [JsonPropertyName("ttl")]public double? TimeToLive { get; set; }

    }
}