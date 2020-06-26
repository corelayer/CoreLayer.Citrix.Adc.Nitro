using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Dns.DnsCNameRec
{
    public class DnsCNameRecAddRequestData : INitroRequestData
    {
        public DnsCNameRecAddRequestData(string aliasName, string canonicalName)
        {
            AliasName = aliasName;
            CanonicalName = canonicalName;
        }
        public string AliasName { get; }
        public string CanonicalName { get; }
        [JsonPropertyName("ttl")]public double? TimeToLive { get; set; }
    }
}