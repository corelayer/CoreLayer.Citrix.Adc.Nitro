using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ns
{
    public class NsTrafficDomainStats
    {
        [JsonPropertyName("td")]public string TrafficDomain { get; set; }
        [JsonPropertyName("nstdtotrxpkts")]public string NsTrafficDomainTotalReceivePackets { get; set; }
        [JsonPropertyName("nstdrxpktsrate")]public double? NsTrafficDomainReceivePacketsRate { get; set; }
        [JsonPropertyName("nstdtottxpkts")]public string NsTrafficDomainTotalTransmitPackets { get; set; }
        [JsonPropertyName("nstdtxpktsrate")]public double? NsTrafficDomainTransmitPacketsRate { get; set; }
        [JsonPropertyName("nstdtotdroppedpkts")]public string NsTrafficDomainTotalDroppedPackets { get; set; }
        [JsonPropertyName("nstddroppedpktsrate")]public double? NsTrafficDomainDroppedPacketsRate { get; set; }
  }
    
}