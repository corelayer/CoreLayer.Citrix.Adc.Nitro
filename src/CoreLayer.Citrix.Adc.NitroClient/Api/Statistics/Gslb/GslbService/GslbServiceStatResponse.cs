using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbService
{
    public class GslbServiceStatResponse : NitroResponse
    {
        [JsonPropertyName("gslbservice")]public GslbServiceStats[] GslbServiceStatistics { get; set; }
    }
}