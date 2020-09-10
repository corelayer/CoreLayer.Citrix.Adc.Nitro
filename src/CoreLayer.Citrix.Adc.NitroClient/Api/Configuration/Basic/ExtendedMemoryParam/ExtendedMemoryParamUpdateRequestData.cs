using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.ExtendedMemoryParam
{
    public class ExtendedMemoryParamUpdateRequestData : INitroRequestData
    {
        [JsonPropertyName("memlimit")]public double? MemoryLimit { get; set; }
    }
}