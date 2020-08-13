using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsSimpleAcl6
{
    public class NsSimpleAcl6StatResponse : NitroResponse
    {
        [JsonPropertyName("nssimpleacl6")]public NsSimpleAcl6Stats NsSimpleAcl6Statistics { get; set; }
    }
}