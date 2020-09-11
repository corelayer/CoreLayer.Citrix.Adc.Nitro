using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ExtendedMemoryParam
{
    public class ExtendedMemoryParamUnsetRequestDataRoot : INitroRequestDataRoot
    {
        [JsonPropertyName("extendedmemoryparam")]public ExtendedMemoryParamUnsetRequestData ExtendedMemoryParamUnsetRequestData => new ExtendedMemoryParamUnsetRequestData();
    }
}