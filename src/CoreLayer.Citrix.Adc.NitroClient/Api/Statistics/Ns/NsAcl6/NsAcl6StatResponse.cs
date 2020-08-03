using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsAcl6
{
    public class NsAcl6StatResponse : NitroResponse
    {
        [JsonPropertyName("nsacl6")]public NsAcl6Stats[] NsAcl6Statistics { get; set; }
    }
}