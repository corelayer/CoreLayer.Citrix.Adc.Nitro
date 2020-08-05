using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ns.NsTrafficDomain
{
    public class NsTrafficDomainStatResponse : NitroResponse
    {
        [JsonPropertyName("nstrafficdomain")]public NsTrafficDomainStats[] TrafficDomainStatistics { get; set; }
    }
}