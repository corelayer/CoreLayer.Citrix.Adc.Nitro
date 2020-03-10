using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public class ServiceGetResponse : NitroResponse
    {
        [JsonPropertyName("Service")]
        public ServiceConfiguration[] Services { get; set; }
    }
}