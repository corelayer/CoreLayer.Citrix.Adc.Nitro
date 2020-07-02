using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.NetProfile
{
    public class NetProfileAddRequestData : INitroRequestData
    {
        public string Name { get; }
        [JsonPropertyName("td")]public double? TrafficDomain { get; set; }
        [JsonPropertyName("srcip")]public string SourecIp { get; set; }
        [JsonPropertyName("srcippersistency")]public string SourceIpPersistency { get; set; }
        public string OverrideLsn { get; set; }

        public NetProfileAddRequestData(string name)
        {
            Name = name;
        }
    }
}