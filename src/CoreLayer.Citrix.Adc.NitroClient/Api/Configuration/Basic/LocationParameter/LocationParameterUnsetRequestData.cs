using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationParameter
{
    public class LocationParameterUnsetRequestData : INitroRequestData
    {
        public bool? Context { get; set; }
        [JsonPropertyName("q1label")]public bool? Qualifier1Label { get; set; }
        [JsonPropertyName("q2label")]public bool? Qualifier2Label { get; set; }
        [JsonPropertyName("q3label")]public bool? Qualifier3Label { get; set; }
        [JsonPropertyName("q4label")]public bool? Qualifier4Label { get; set; }
        [JsonPropertyName("q5label")]public bool? Qualifier5Label { get; set; }
        [JsonPropertyName("q6label")]public bool? Qualifier6Label { get; set; }
    }
}