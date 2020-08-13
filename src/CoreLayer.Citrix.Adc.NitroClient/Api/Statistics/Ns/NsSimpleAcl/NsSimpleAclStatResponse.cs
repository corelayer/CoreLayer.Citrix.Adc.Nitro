using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsSimpleAcl
{
    public class NsSimpleAclStatResponse : NitroResponse
    {
        [JsonPropertyName("nssimpleacl")]public NsSimpleAclStats NsSimpleAclStatistics { get; set; }
    }
}