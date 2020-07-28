using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbServiceGroup
{
    public class GslbServiceGroupStatResponse : NitroResponse
    {
        [JsonPropertyName("gslbservicegroup")]public GslbServiceGroupStats[] GslbServiceGroupStatistics { get; set; }
    }
}