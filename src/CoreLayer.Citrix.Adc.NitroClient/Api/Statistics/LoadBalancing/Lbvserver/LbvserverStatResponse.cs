using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.LoadBalancing;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.LoadBalancing.Lbvserver
{
    public class LbvserverStatResponse : NitroResponse
    {
        [JsonPropertyName("lbvserver")]
        public LbvserverStats[] LbvserversStats { get; set; }
    }
}