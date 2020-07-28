using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbDomain
{
    public class GslbDomainStatResponse : NitroResponse
    {
        [JsonPropertyName("gslbdomain")]public GslbDomainStats[] GslbDomainStatistics { get; set; }
    }
}