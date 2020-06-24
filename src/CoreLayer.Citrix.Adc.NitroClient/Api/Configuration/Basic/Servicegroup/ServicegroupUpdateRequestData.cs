using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup
{
    public abstract class ServicegroupUpdateRequestData : INitroRequestData
    {
        public string ServicegroupName { get; }

        public ServicegroupUpdateRequestData(string servicegroupName)
        {
            ServicegroupName = servicegroupName;
        }
        
        public string ServerName { get; set; }
        public int? Port { get; set; }
        public double? Weight { get; set; }
        public string CustomServerId { get; set; }
        public double? ServerId { get; set; }
        public double? HashId { get; set; }
        [JsonPropertyName("monitor_name_svc")]public string MonitorNameService { get; set; }
        [JsonPropertyName("dup_weight")]public double? DuplicateWeight { get; set; }
        public double? MaxClient { get; set; } 
        [JsonPropertyName("maxreq")]public double? MaxRequests { get; set; }
        [JsonPropertyName("cip")]public string InjectClientIp { get; set; } 
        [JsonPropertyName("cipheader")]public string ClientIpHeader { get; set; } 
        [JsonPropertyName("usip")]public string UseSourceIp { get; set; } 
        public string PathMonitor { get; set; }
        [JsonPropertyName("pathmonitorindv")]public string PathMonitorIndividual { get; set; }
        public string UseProxyPort { get; set; } 
        public string HealthMonitor { get; set; }
        //public string RtspSessionIdRemap { get; set; }
        [JsonPropertyName("clttimeout")]public double? ClientTimeout { get; set; } 
        [JsonPropertyName("svrtimeout")]public double? ServerTimeout { get; set; } 
        [JsonPropertyName("cka")]public string ClientKeepAlive { get; set; }
        [JsonPropertyName("tcpb")]public string TcpBuffering { get; set; }
        public double? MaxBandwidth { get; set; } 
        [JsonPropertyName("monthreshold")]public double? MonitorWeightThreshold { get; set; }
        public string DownstateFlush { get; set; }
        public string Comment { get; set; }
        [JsonPropertyName("appflowlog")]public string AppFlowLogging { get; set; }
        public string NetProfile { get; set; }
        [JsonPropertyName("monconnectionclose")]public string MonitorConnectionClose { get; set; }
    }
}