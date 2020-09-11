using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ExtendedMemoryParam
{
    public class ExtendedMemoryParamGetResponse : NitroResponse
    {
        [JsonPropertyName("extendedmemoryparam")]public ExtendedMemoryParamConfiguration ExtendedMemoryParam { get; set; }
    }
}