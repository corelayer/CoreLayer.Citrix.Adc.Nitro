using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsPbr6
{
    public class NsPbr6StatResponse : NitroResponse
    {
        [JsonPropertyName("nspbr6")]public NsPbr6Stats[] NsPbr6Statistics { get; set; }
    }
}