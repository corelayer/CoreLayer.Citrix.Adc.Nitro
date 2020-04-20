namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public interface IServicegroupConfiguration
    {
        string ServicegroupName { get; set; }
        string ServiceType { get; set; }
        string CacheType { get; set; }
        string Td { get; set; } 
        string MaxClient { get; set; }
        string MaxReq { get; set; } 
        string Cacheable { get; set; }
        string Cip { get; set; } 
        string CipHeader { get; set; } 
        string Usip { get; set; } 
        string PathMonitor { get; set; }
        string PathMonitorIndv { get; set; } 
        string UseProxyPort { get; set; }
        string HealthMonitor { get; set; }
        string Sc { get; set; } 
        string Sp { get; set; } 
        string RtspSessionIdRemap { get; set; }
        double? CltTimeout { get; set; } 
        double? SvrTimeout { get; set; } 
        string Cka { get; set; } 
        string TcpB { get; set; } 
        string Cmp { get; set; } 
        string MaxBandWidth { get; set; }
        string MonThreshold { get; set; } 
        string State { get; set; }
        string DownStateFlush { get; set; }
        string TcpProfileName { get; set; }
        string HttpProfileName { get; set; }
        string Comment { get; set; }
        string AppFlowLog { get; set; } 
        string NetProfileName { get; set; } 
        string AutoScale { get; set; }
        int? MemberPort { get; set; }
        string MonConnectionsClose { get; set; } 
        string ServerName { get; set; }
        int? Port { get; set; }
        string Weight { get; set; }
        string CustomServerId { get; set; }
        string ServerId { get; set; }
        string HashId { get; set; }
        string MonitorNameSvc { get; set; } //[JsonPropertyName("monitor_name_svc")]
        string DupWeight { get; set; } //[JsonPropertyName("dup_weight")]
        int? RiseApbrStatsMsgCode { get; set; } 
        double? Delay { get; set; }
        string Graceful { get; set; }
        bool? IncludeMembers { get; set; }
        string NewName { get; set; }
        int? NumOfConnections { get; set; } 
        bool? ServiceConfType { get; set; } 
        string Value { get; set; }
        string SvrState { get; set; } 
        string Ip { get; set; }
        int? MonStatCode { get; set; } 
        int? MonStatParam1 { get; set; } 
        int? MonStatParam2 { get; set; } 
        int? MonStatParam3 { get; set; } 
        string StateChangeTimeMSec { get; set; }
        string StateUpdateReason { get; set; }
        string ClMonOwner { get; set; } 
        string ClMonView { get; set; } 
        string GroupCount { get; set; }
        int? RiseApbrStatsMsgCode2 { get; set; } 
        string ServiceIpStr { get; set; }
        string ServicegroupEffectiveState { get; set; }
        string MonWeight { get; set; } 
        string MonitorState { get; set; } //[JsonPropertyName("monitor_state")]
        string MonitorTotalProbes { get; set; }
        string MonitorTotalFailedProbes { get; set; }
        string MonitorCurrentFailedProbes { get; set; }
        string StateChangeTimeSec { get; set; }
        string NoDefaultBindings { get; set; }
        string NameServer { get; set; }
        double? Dbsttl { get; set; }
        string SvcItmactscvs { get; set; }
        string SvcitmBoundSvcs { get; set; }
        string ResponseTime { get; set; }
        double? Count { get; set; } //[JsonPropertyName("__count")]
        
    }
}