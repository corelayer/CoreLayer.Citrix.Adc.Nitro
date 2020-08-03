using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsAcl
{
    public class NsAclStatResponse : NitroResponse
    {
        [JsonPropertyName("nsacl")]public NsAclStats[] NsAclStatistics { get; set; }
    }
}