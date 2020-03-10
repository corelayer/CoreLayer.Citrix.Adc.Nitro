using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.LoadBalancing;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorGetResponse : NitroResponse
    {
        [JsonPropertyName("lbmonitor")]
        public LbmonitorConfiguration[] Lbmonitors { get; set; }
    }
}