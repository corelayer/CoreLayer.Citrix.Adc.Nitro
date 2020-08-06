using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.System;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.System.SystemBw
{
    public class SystemBwStatResponse : NitroResponse
    {
        [JsonPropertyName("systembw")]public SystemBwStats[] SystemBwStatistics { get; set; }
    }
}