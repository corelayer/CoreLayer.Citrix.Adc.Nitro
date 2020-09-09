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
        public double? MaxReq { get; set; }//MaxRequests { get; set; }
        //public string Cacheable { get; set; }
        public string Cip { get; set; }//InjectClientIp { get; set; }
        public string CipHeader { get; set; }//ClientIpHeader { get; set; } 
        public string Usip { get; set; }//UseSourceIp { get; set; }
        //public string PathMonitor { get; set; }
        //public string PathMonitorIndv { get; set; }
        public string UseProxyPort { get; set; }
        //public string Sc { get; set; } 
        //public string Sp { get; set; } 
        //public string RtspSessionIdRemap { get; set; }
        public double? CltTimeout { get; set; }//ClientTimeOut { get; set; } 
        public double? SvrTimeout { get; set; }//ServerTimeout { get; set; }
        public string CustomServerId { get; set; }
        public double? ServerId { get; set; } 
        public string Cka { get; set; }//ClientKeepAlive { get; set; } 
        public string TcpB { get; set; }//TcpBuffering { get; set; }
        //public string Cmp { get; set; }
        public double? MaxBandwidth { get; set; }
        public string AccessDown { get; set; } 
        public double? MonThreshold { get; set; }//MonitorWeightThreshold { get; set; } 
        public string State { get; set; }
        public string DownStateFlush { get; set; }
        //public string TcpProfileName { get; set; }
        //public string HttpProfileName { get; set; } 
        public double? HashId { get; set; }
        public string Comment { get; set; }
        public string AppFlowLog { get; set; }//AppFlowLogging { get; set; }
        public string NetProFile { get; set; }
        public double? Td { get; set; }//TrafficDomain { get; set; }
        public string ProcessLocal { get; set; }
        public string MonConnectionClose { get; set; }//MonitorConnectionClose { get; set; }
        public string ContentInspectionProfileName { get; set; }
    }
}