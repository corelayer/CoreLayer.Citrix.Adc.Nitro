using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ha
{
    public class HaNodeStats
    {
        [JsonPropertyName("hacurstatus")]public string HighAvailabilityCurrentStatus { get; set; }
        [JsonPropertyName("hacurstate")]public string HighAvailabilityCurrentState { get; set; }
        [JsonPropertyName("hacurmasterstate")]public string HighAvailabilityCurrentMasterState { get; set; }
        [JsonPropertyName("transtime")]public string LastTransitionTime { get; set; }
        [JsonPropertyName("hatotpktrx")]public string HighAvailabilityTotalPacketReceive { get; set; }
        [JsonPropertyName("hapktrxrate")]public double? HighAvailabilityPacketReceiveRate { get; set; }
        [JsonPropertyName("hatotpkttx")]public string HighAvailabilityTotalPacketTransmit { get; set; }
        [JsonPropertyName("hapkttxrate")]public double? HighAvailabilityPacketTransmitRate { get; set; }
        [JsonPropertyName("haerrsyncfailure")]public string HighAvailabilityErrorSyncFailure { get; set; }
        [JsonPropertyName("haerrproptimeout")]public string HighAvailabilityErrorPropagationTimedOut { get; set; }
    }
}