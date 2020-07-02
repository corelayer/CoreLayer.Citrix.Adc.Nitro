using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbmonitor
{
    public class LbmonitorAddTcpEcvRequestData : LbmonitorAddRequestData
    {
        public string MonitorName { get; }
        public string Type => "TCP-ECV";
        
        public LbmonitorAddTcpEcvRequestData(string monitorName)
        {
            MonitorName = monitorName;
        }     
        
        public string Send { get; set; }
        [JsonPropertyName("recv")]public string Receive { get; set; }
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