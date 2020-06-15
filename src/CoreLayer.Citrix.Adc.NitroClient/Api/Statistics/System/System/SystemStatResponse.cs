using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.System;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.System.System
{
    public class SystemStatResponse : NitroResponse
    {
        [JsonPropertyName("system")]
        public SystemStats SystemStatistics { get; set; }
    }
}