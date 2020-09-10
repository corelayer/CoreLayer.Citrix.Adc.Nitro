using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.LocationParameter
{
    public class LocationParameterUpdateRequestData : INitroRequestData
    {
        public string Context { get; set; }
        [JsonPropertyName("q1label")]public string Qualifier1Label { get; set; }
        [JsonPropertyName("q2label")]public string Qualifier2Label { get; set; }
        [JsonPropertyName("q3label")]public string Qualifier3Label { get; set; }
        [JsonPropertyName("q4label")]public string Qualifier4Label { get; set; }
        [JsonPropertyName("q5label")]public string Qualifier5Label { get; set; }
        [JsonPropertyName("q6label")]public string Qualifier6Label { get; set; }
        
    }
}