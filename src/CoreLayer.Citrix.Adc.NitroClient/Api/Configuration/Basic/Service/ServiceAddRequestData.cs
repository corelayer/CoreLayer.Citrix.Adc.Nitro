using System.Net;
using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Service
{
    public abstract class ServiceAddRequestData : INitroRequestData
    {
        public string Name { get; }
        public string Ip { get; }
        public string ServerName { get; }
        public abstract string ServiceType { get; }
        public abstract int Port { get; }

        public ServiceAddRequestData(string serviceName, string target)
        {
            Name = serviceName;
            if (IPAddress.TryParse(target, out IPAddress ipAddress))
            {
                Ip = ipAddress.ToString();
            }
            else
            {
                ServerName = target;
            }
        }

        //public string ClearTextPort { get; set; } 
        //public string CacheType { get; set; } 
        public double? MaxClient { get; set; } 
        public string HealthMonitor { get; set; } 
        [JsonPropertyName("maxreq")]public double? MaxRequests { get; set; }
        //public string Cacheable { get; set; }
        [JsonPropertyName("cip")]public string InjectClientIp { get; set; }
        [JsonPropertyName("cipheader")]public string ClientIpHeader { get; set; } 
        [JsonPropertyName("usip")]public string UseSourceIp { get; set; }
        //public string PathMonitor { get; set; }
        //public string PathMonitorIndv { get; set; }
        public string UseProxyPort { get; set; }
        //public string Sc { get; set; } 
        //public string Sp { get; set; } 
        //public string RtspSessionIdRemap { get; set; }
        [JsonPropertyName("clttimeout")]public double? ClientTimeOut { get; set; } 
        [JsonPropertyName("svrtimeout")]public double? ServerTimeout { get; set; }
        public string CustomServerId { get; set; }
        public double? ServerId { get; set; } 
        [JsonPropertyName("cka")]public string ClientKeepAlive { get; set; } 
        [JsonPropertyName("tcpb")]public string TcpBuffering { get; set; }
        //public string Cmp { get; set; }
        public double? MaxBandwidth { get; set; }
        public string AccessDown { get; set; } 
        [JsonPropertyName("monthreshold")]public double? MonitorWeightThreshold { get; set; } 
        public string State { get; set; }
        public string DownStateFlush { get; set; }
        //public string TcpProfileName { get; set; }
        //public string HttpProfileName { get; set; } 
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