using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.Servicegroup.ServicegroupUpdateRequestDatas
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
        public string Monitor_Name_Svc { get; set; }
        public double? Dup_Weight { get; set; }
        public double? MaxClient { get; set; } 
        public double? MaxReq { get; set; }
        public string Cip { get; set; } 
        public string CipHeader { get; set; } 
        public string Usip { get; set; } 
        public string PathMonitor { get; set; }
        public string PathMonitorIndv { get; set; }
        public string UseProxyPort { get; set; } 
        public string HealthMonitor { get; set; }
        //public string RtspSessionIdRemap { get; set; }
        public double? CltTimeout { get; set; } 
        public double? SvrTimeout { get; set; } 
        public string Cka { get; set; }
        public string Tcpb { get; set; }
        public double? MaxBandwidth { get; set; } 
        public double? MonThreshold { get; set; }
        public string DownstateFlush { get; set; }
        public string Comment { get; set; }
        public string AppFlowLog { get; set; }
        public string NetProfile { get; set; }
        public string MonConnectionClose { get; set; }
    }
}