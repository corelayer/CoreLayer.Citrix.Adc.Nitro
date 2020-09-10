using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public abstract class ServiceUpdateRequestData : INitroRequestData
    {
        public string Name { get; }

        public ServiceUpdateRequestData(string serviceName)
        {
            Name = serviceName;
        }
        
        public string IpAddress { get; set; }
        public double? MaxClient { get; set; } 
        public string HealthMonitor { get; set; } 
        [JsonPropertyName("maxreq")]public double? MaxRequests { get; set; }
        [JsonPropertyName("cip")]public string InjectClientIp { get; set; }
        [JsonPropertyName("cipheader")]public string ClientIpHeader { get; set; } 
        [JsonPropertyName("usip")]public string UseSourceIp { get; set; }
        public string PathMonitor { get; set; }
        [JsonPropertyName("pathmonitorindv")]public string PathMonitorIndividual { get; set; }
        public string UseProxyPort { get; set; }
        //public string RtspSessionIdRemap { get; set; }
        [JsonPropertyName("clttimeout")]public double? ClientTimeOut { get; set; } 
        [JsonPropertyName("svrtimeout")]public double? ServerTimeout { get; set; }
        public string CustomServerId { get; set; }
        public double? ServerId { get; set; } 
        [JsonPropertyName("cka")]public string ClientKeepAlive { get; set; } 
        [JsonPropertyName("tcpb")]public string TcpBuffering { get; set; }
        public double? MaxBandwidth { get; set; }
        public string AccessDown { get; set; } 
        [JsonPropertyName("monthreshold")]public double? MonitorWeightThreshold { get; set; }
        public double? Weight { get; set; }
        [JsonPropertyName("monitor_name_svc")]public string MonitorNameService { get; set; }
        public string DownStateFlush { get; set; }
        public double? HashId { get; set; }
        public string Comment { get; set; }
        [JsonPropertyName("appflowlog")]public string AppFlowLogging { get; set; }
        public string NetProFile { get; set; }
        [JsonPropertyName("td")]public double? TrafficDomain { get; set; }
        public string ProcessLocal { get; set; }
        [JsonPropertyName("monconnectionclose")]public string MonitorConnectionClose { get; set; }
        public string ContentInspectionProfileName { get; set; }
    }
}