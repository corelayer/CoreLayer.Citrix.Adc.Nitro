using System.Dynamic;
using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class LocationParameterConfiguration
    {
        public string Context { get; set; }
        [JsonPropertyName("q1label")]public string Qualifier1Label { get; set; }
        [JsonPropertyName("q2label")]public string Qualifier2Label { get; set; }
        [JsonPropertyName("q3label")]public string Qualifier3Label { get; set; }
        [JsonPropertyName("q4label")]public string Qualifier4Label { get; set; }
        [JsonPropertyName("q5label")]public string Qualifier5Label { get; set; }
        [JsonPropertyName("q6label")]public string Qualifier6Label { get; set; }
        public string LocationFile { get; set; }
        public string Format { get; set; }
        public string Custom { get; set; }
        public string Static { get; set; }
        public string Lines { get; set; }
        public string Errors { get; set; }
        public string Warnings { get; set; }
        public string Entries { get; set; }
        public string LocationFile6 { get; set; }
        public string Format6 { get; set; }
        public string Custom6 { get; set; }
        public string Lines6 { get; set; }
        public string Errors6 { get; set; }
        public string Warnings6 { get; set; }
        public string Entries6 { get; set; }
        public string Flags { get; set; }
        public string Status { get; set; }
        public string DatabaseMode { get; set; }
        public string Flushing { get; set; }
        public string Loading { get; set; }
        public string MatchWildcardToAny { get; set; }
        public string[] BuiltIn { get; set; }
        public string Feature { get; set; }
    
    }
}