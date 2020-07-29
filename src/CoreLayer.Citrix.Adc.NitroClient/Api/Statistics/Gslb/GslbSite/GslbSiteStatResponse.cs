using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbSite
{
    public class GslbSiteStatResponse : NitroResponse
    {
        [JsonPropertyName("gslbsite")]public GslbSiteStats[] GslbSiteStatistics { get; set; }
    }
}