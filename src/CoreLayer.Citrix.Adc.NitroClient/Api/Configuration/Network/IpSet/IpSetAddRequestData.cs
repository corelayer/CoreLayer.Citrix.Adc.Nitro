using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.IpSet
{
    public class IpSetAddRequestData : INitroRequestData
    {
        public string Name { get; }
        [JsonPropertyName("td")]public double? TrafficDomain { get; set; }

        public IpSetAddRequestData(string ipSetName)
        {
            Name = ipSetName;
        }
    }
}