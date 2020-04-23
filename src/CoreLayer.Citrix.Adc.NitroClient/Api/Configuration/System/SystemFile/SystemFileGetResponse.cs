using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.System;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemFile
{
    public class SystemFileGetResponse : NitroResponse
    {
        [JsonPropertyName("systemfile")]
        public SystemFileConfiguration[] SystemFiles { get; set; }
    }
}