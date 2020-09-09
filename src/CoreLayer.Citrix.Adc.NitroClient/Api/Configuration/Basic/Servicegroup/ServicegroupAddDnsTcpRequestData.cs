using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup
{
    public class ServicegroupAddDnsTcpRequestData : ServicegroupAddRequestData
    {
        public ServicegroupAddDnsTcpRequestData(string servicegroupName) : base(servicegroupName)
        {
        }

        public override string ServiceType { get; } = "DNS_TCP";
        
        public double? Td { get; set; }//TrafficDomain { get; set; } 
        public double? MaxClient { get; set; }
        public double? MaxReq { get; set; }//MaxRequests { get; set; }
        public string Cip { get; set; } //InjectClientIp { get; set; }
        public string CipHeader { get; set; }//ClientIpHeader { get; set; }
        public string Usip { get; set; }//UseSourceIp { get; set; }
        public string UseProxyPort { get; set; }
        public string HealthMonitor { get; set; }
        public string Sp { get; set; }//SurgeProtection { get; set; }
        public double? CltTimeout { get; set; }//ClientTimeout { get; set; } 
        public double? SvrTimeout { get; set; }//ServerTimeout { get; set; } 
        public string Cka { get; set; }//ClientKeepAlive { get; set; }
        public string TcpB { get; set; }//TcpBuffering { get; set; }
        public double? MaxBandwidth { get; set; }
        public double? MonThreshold { get; set; }//MonitorWeightThreshold { get; set; } 
        public string State { get; set; }
        public string DownstateFlush { get; set; }
        public string TcpProfileName { get; set; }
        public string Comment { get; set; }
        public string AppFlowLog { get; set; }//AppFlowLogging { get; set; }
        public string NetProfile { get; set; }
        public string AutoScale { get; set; }
        public double? AutoDisableDelay { get; set; }
        public string AutoDisableGraceful { get; set; }
        public string MonConnectionClose { get; set; }//MonitorConnectionClose { get; set; }

    }
}