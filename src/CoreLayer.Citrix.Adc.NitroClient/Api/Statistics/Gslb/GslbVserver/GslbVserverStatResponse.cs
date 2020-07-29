using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbVserver
{
    public class GslbVserverStatResponse : NitroResponse
    {
        [JsonPropertyName("gslbvserver")]public GslbVserverStats[] GslbVserverStatistics { get; set; }
    }
}