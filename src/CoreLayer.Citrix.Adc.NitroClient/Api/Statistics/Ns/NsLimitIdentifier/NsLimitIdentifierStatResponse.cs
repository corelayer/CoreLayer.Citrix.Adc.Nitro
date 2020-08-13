using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsLimitIdentifier
{
    public class NsLimitIdentifierStatResponse : NitroResponse
    {
        [JsonPropertyName("nslimitidentifier")]public NsLimitIdentifierStats[] NsLimitIdentifierStatistics { get; set; }
    }
}