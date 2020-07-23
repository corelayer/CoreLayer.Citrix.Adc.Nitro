using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Basic.Service
{
    public class ServiceStatResponse : NitroResponse
    {
        [JsonPropertyName("service")]
        public ServiceStatistics ServicesStats { get; set; }
    }
}