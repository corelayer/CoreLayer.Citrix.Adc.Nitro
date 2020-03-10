using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.LoadBalancing;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver
{
    public class LbvserverGetResponse : NitroResponse
    {
        [JsonPropertyName("lbvserver")]
        public LbvserverConfiguration[] Lbvservers { get; set; }

    }
}