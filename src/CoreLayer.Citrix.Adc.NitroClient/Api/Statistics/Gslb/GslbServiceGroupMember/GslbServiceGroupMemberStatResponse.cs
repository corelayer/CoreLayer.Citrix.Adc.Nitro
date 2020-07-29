using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Gslb;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Gslb.GslbServiceGroupMember
{
    public class GslbServiceGroupMemberStatResponse : NitroResponse
    {
        [JsonPropertyName("gslbservicegroupmember")]public GslbServiceGroupMemberStats GslbServiceGroupMemberStatistics { get; set; }
    }
}