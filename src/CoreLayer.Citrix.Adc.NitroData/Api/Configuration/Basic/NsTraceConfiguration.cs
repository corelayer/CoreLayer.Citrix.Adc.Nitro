using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class NsTraceConfiguration
    {
        public string NodeId { get; set; }
        public string State { get; set; }
        public string Scope { get; set; }
        public string TraceLocation { get; set; }
        [JsonPropertyName("nf")]public string NumberOfFilesInCycle { get; set; }
        public string Time { get; set; }
        public string Size { get; set; }
        public string[] Mode { get; set; }
        public string TraceFormat { get; set; }
        public string PerNic { get; set; }
        public string FileName { get; set; }
        public string FileId { get; set; }
        public string Filter { get; set; }
        public string Link { get; set; }
        public string[] Nodes { get; set; }
        public string Merge { get; set; }
        public string DoRunTimeCleanUp { get; set; }
        public string TraceBuffers { get; set; }
        [JsonPropertyName("skiprpc")]public string SkipRpcPackets { get; set; }
        public string SkipLocalSsh { get; set; }
        [JsonPropertyName("capsslkeys")]public string CaptureSslKeys { get; set; }
        [JsonPropertyName("capdroppkt")]public string CaptureDroppedPkt { get; set; }
        public string InMemoryTrace { get; set; }
        
    }
}