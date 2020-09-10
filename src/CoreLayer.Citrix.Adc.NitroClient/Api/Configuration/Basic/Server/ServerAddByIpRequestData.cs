using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Server
{
    public class ServerAddByIpRequestData : INitroRequestData
    {
        public string Name { get; }
        public string IpAddress { get; }
        public string State { get; set; }
        public string Comment { get; set; }
        [JsonPropertyName("td")]public double? TrafficDomain { get; set; }

        public ServerAddByIpRequestData(string serverName, string ipAddress)
        {
            Name = serverName;
            IpAddress = ipAddress;
        }

        public override string ToString()
        {
            return "Name:" + Name;
        }
    }
}