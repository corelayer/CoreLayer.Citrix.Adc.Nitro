using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Basic.Servicegroup
{
    public class ServicegroupStatResponse : NitroResponse
    {
        [JsonPropertyName("servicegroup")]
        public ServicegroupStatistics[] ServicegroupsStats { get; set; }
    }
}