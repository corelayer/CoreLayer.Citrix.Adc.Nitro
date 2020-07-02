using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorAddTcpRequestData : LbmonitorAddRequestData
    {
        public string MonitorName { get; }
        public string Type => "TCP";
        
        public LbmonitorAddTcpRequestData(string monitorName)
        {
            MonitorName = monitorName;
        }    
        [JsonPropertyName("lrtm")]public string LeastResponseTime { get; set; }
        public double? Deviation { get; set; }
        [JsonPropertyName("units1")]public string DeviationUnits { get; set; } 
        [JsonPropertyName("destip")]public string DestinationIp { get; set; }
        [JsonPropertyName("destport")]public int? DestinationPort { get; set; }
        public string Transparent { get; set; } 
        public string IpTunnel { get; set; } 
        public string Tos { get; set; } 
        public double? TosId { get; set; } 
    }
}