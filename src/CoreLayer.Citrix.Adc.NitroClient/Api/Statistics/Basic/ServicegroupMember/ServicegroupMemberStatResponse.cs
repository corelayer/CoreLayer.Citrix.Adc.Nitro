using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Basic.ServicegroupMember
{
    public class ServicegroupMemberStatResponse : NitroResponse
    {
        [JsonPropertyName("servicegroupmember")]
        public ServicegroupMemberStatistics[] ServicegroupMemberStatistics { get; set; }
    }
}