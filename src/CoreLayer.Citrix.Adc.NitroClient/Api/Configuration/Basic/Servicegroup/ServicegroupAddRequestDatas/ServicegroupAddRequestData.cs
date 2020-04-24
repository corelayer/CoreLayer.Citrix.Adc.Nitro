using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup.ServicegroupAddRequestDatas
{
    public abstract class ServicegroupAddRequestData : INitroRequestData
    {
        public string ServicegroupName { get; }
        public abstract string ServiceType { get; }

        public ServicegroupAddRequestData(string servicegroupName)
        {
            ServicegroupName = servicegroupName;
        }
        
        
//        public string CacheType { get; set; } 
//        public double? Td { get; set; }
//        public double? MaxClient { get; set; } 
//        public double? MaxReq { get; set; }
//        public string Cacheable { get; set; }
//        public string Cip { get; set; } 
//        public string CipHeader { get; set; } 
//        public string Usip { get; set; } 
//        //public string PathMonitor { get; set; }= "YES";
//        //public string PathMonitorIndv { get; set; }
//        public string UseProxyPort { get; set; } 
//        public string HealthMonitor { get; set; } 
//        public string Sc { get; set; }
//        public string Sp { get; set; }
//        //public string RtspSessionIdRemap { get; set; } = "YES";
//        public double? CltTimeout { get; set; } 
//        public double? SvrTimeout { get; set; } 
//        public string Cka { get; set; }
//        public string Tcpb { get; set; }
//        //public string Cmp { get; set; }= "YES";
//        public double? MaxBandwidth { get; set; } 
//        public double? MonThreshold { get; set; } 
//        public string State { get; set; }
//        public string DownstateFlush { get; set; }
//        public string TcpProfileName { get; set; }
//        public string HttpProfileName { get; set; } 
//        public string Comment { get; set; }
//        public string AppFlowLog { get; set; }
//        public string NetProfile { get; set; }
//        public string AutoScale { get; set; }
//        public int MemberPort { get; set; } =1;
//        public double? AutoDisableDelay { get; set; }
//        public string AutoDisableGraceful { get; set; }
//        public string MonConnectionClose { get; set; }
    }
}