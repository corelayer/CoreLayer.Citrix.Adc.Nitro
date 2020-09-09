using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.NsTrace
{
    public class NsTraceGetResponse : NitroResponse
    {
        [JsonPropertyName("nstrace")]public NsTraceConfiguration[] NsTraceConfigurations { get; set; }
    }
}