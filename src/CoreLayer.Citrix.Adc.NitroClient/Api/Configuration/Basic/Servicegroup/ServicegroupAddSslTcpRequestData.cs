using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup
{
    public class ServicegroupAddSslTcpRequestData : ServicegroupAddRequestData
    {
        public ServicegroupAddSslTcpRequestData(string servicegroupName) : base(servicegroupName)
        {
        }

        public override string ServiceType { get; } = "SSL_TCP";
        
        public string CacheType { get; set; } 
        [JsonPropertyName("td")]public double? TrafficDomain { get; set; }
        public double? MaxClient { get; set; } 
        [JsonPropertyName("maxreq")]public double? MaxRequests { get; set; } 
        public string Cacheable { get; set; }
        [JsonPropertyName("cip")]public string InjectClientIp { get; set; }
        [JsonPropertyName("cipheader")]public string ClientIpHeader { get; set; }
        [JsonPropertyName("usip")]public string UseSourceIp { get; set; }
        public string UseProxyPort { get; set; } 
        public string HealthMonitor { get; set; } 
        [JsonPropertyName("sc")]public string SureConnect { get; set; } 
        [JsonPropertyName("sp")]public string SurgeProtection { get; set; }
        [JsonPropertyName("clttimeout")]public double? ClientTimeout { get; set; } 
        [JsonPropertyName("svrtimeout")]public double? ServerTimeout { get; set; } 
        [JsonPropertyName("cka")]public string ClientKeepAlive { get; set; }
        [JsonPropertyName("tcpb")]public string TcpBuffering { get; set; }
        public double? MaxBandwidth { get; set; } 
        [JsonPropertyName("monthreshold")]public double? MonitorWeightThreshold { get; set; } 
        public string State { get; set; }
        public string DownstateFlush { get; set; }
        public string TcpProfileName { get; set; }
        public string Comment { get; set; }
        [JsonPropertyName("appflowlog")]public string AppFlowLogging { get; set; }
        public string NetProfile { get; set; }
        public string AutoScale { get; set; }
        public double? AutoDisableDelay { get; set; }
        public string AutoDisableGraceful { get; set; }
        [JsonPropertyName("monconnectionclose")]public string MonitorConnectionClose { get; set; }
    }
}