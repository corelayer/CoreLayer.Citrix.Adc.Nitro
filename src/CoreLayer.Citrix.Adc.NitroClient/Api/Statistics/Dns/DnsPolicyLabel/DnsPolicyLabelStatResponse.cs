using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Dns;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Dns.DnsPolicyLabel
{
    public class DnsPolicyLabelStatResponse : NitroResponse
    {
        [JsonPropertyName("dnspolicylabel")]public DnsPolicyLabelStats DnsPolicyLabelStatistics { get; set; }
    }
}