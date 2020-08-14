using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ExtendedMemoryParam
{
    public class ExtendedMemoryParamUnsetRequestData : INitroRequestData
    {
        [JsonPropertyName("memlimit")]public bool MemoryLimit => true;
    }
}