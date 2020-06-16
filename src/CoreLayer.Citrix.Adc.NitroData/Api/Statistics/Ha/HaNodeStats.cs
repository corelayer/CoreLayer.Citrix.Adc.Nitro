using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ha
{
    public class HaNodeStats
    {
        [JsonPropertyName("hacurstatus")]public string HaCurrentStatus { get; set; }
        [JsonPropertyName("hacurstate")]public string HaCurrentState { get; set; }
        [JsonPropertyName("hacurmasterstate")]public string HaCurrentMasterState { get; set; }
        [JsonPropertyName("transtime")]public string LastTransitionTime { get; set; }
        [JsonPropertyName("hatotpktrx")]public string HaTotalPacketRx { get; set; }
        [JsonPropertyName("hapktrxrate")]public double? HaPacketRxRate { get; set; }
        [JsonPropertyName("hatotpkttx")]public string HaTotalPacketTx { get; set; }
        [JsonPropertyName("hapkttxrate")]public double? HaPacketTxRate { get; set; }
        public string HaErrSyncFailure { get; set; }
        [JsonPropertyName("haerrproptimeout")]public string HaErrorPropagationTimedOut { get; set; }
    }
}