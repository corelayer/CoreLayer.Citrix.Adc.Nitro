using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Network;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.IpSet
{
    public class IpSetGetResponse : NitroResponse
    {
        [JsonPropertyName("ipset")]
        public IpSetConfiguration[] IpSets { get; set; }
    }
}