using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ica;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ica.IcaPolicy
{
    public class IcaPolicyStatResponse : NitroResponse
    {
        [JsonPropertyName("icapolicy")]public IcaPolicyStats[] IcaPolicyStatistics { get; set; }
    }
}