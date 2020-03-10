namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public interface IServicegroupConfiguration
    {
        string ServicegroupName { get; set; }
        string ServiceType { get; set; }
        string CacheType { get; set; }
        string TrafficDomain { get; set; } //[JsonPropertyName("td")]
        string MaxClient { get; set; }
        string MaxRequests { get; set; } //[JsonPropertyName("maxreq")]
        string Cacheable { get; set; }
        string ClientIp { get; set; } //[JsonPropertyName("cip")]
        string ClientIpHeader { get; set; } //[JsonPropertyName("cipheader")]
        string UseSourceIp { get; set; } //[JsonPropertyName("usip")]
        string PathMonitor { get; set; }
        string PathMonitorIndividual { get; set; } //[JsonPropertyName("pathmonitorindv")]
        string UseProxyPort { get; set; }
        string HealthMonitor { get; set; }
        string SureConnect { get; set; } //[JsonPropertyName("sc")]
        string SurgeProtection { get; set; } //[JsonPropertyName("sp")]
        string RtspSessionIdRemap { get; set; }
        double? ClientTimeout { get; set; } //[JsonPropertyName("clttimeout")]
        double? ServerTimeout { get; set; } //[JsonPropertyName("svrtimeout")]
        string ClientKeepAlive { get; set; } //[JsonPropertyName("cka")]
        string TcpBuffering { get; set; } //[JsonPropertyName("tcpb")]
        string Compression { get; set; } //[JsonPropertyName("Cmp")]
        string MaxBandWidth { get; set; }
        string MonitorWeightThreshold { get; set; } //[JsonPropertyName("monthreshold")]
        string State { get; set; }
        string DownStateFlush { get; set; }
        string TcpProfileName { get; set; }
        string HttpProfileName { get; set; }
        string Comment { get; set; }
        string AppFlowLogging { get; set; } //[JsonPropertyName("appflowlog")]
        string NetworkProfileName { get; set; } //[JsonPropertyName("netprofile")]
        string AutoScale { get; set; }
        int? MemberPort { get; set; }
        string MonitoringConnectionsClose { get; set; } //[JsonPropertyName("monconnectionclose")]
        string ServerName { get; set; }
        int? Port { get; set; }
        string Weight { get; set; }
        string CustomServerId { get; set; }
        string ServerId { get; set; }
        string HashId { get; set; }
        string MonitorNameSvc { get; set; } //[JsonPropertyName("monitor_name_svc")]
        string DupWeight { get; set; } //[JsonPropertyName("dup_weight")]
        int? RiseApbrStatusMessageCode { get; set; } //[JsonPropertyName("riseapbrstatsmsgcode")]
        double? Delay { get; set; }
        string Graceful { get; set; }
        bool? IncludeMembers { get; set; }
        string NewName { get; set; }
        int? NumberOfConnections { get; set; } //[JsonPropertyName("numofconnections")]
        bool? ServiceConfigurationType { get; set; } //[JsonPropertyName("serviceconftype")]
        string Value { get; set; }
        string ServerState { get; set; } //[JsonPropertyName("svrstate")]
        string Ip { get; set; }
        int? MonitorStatCode { get; set; } //[JsonPropertyName("monstatcode")]
        int? MonitorStatParam1 { get; set; } //[JsonPropertyName("monstatparam1")]
        int? MonitorStatParam2 { get; set; } //[JsonPropertyName("monstatparam2")]
        int? MonitorStatParam3 { get; set; } //[JsonPropertyName("monstatparam3")]
        string StateChangeTimeMSec { get; set; }
        string StateUpdateReason { get; set; }
        string ClMonitorOwner { get; set; } //[JsonPropertyName("clmonowner")]
        string ClMonitorView { get; set; } //[JsonPropertyName("clmonview")]
        string GroupCount { get; set; }
        int? RiseApbrStatusMessageCode2 { get; set; } //[JsonPropertyName("riseapbrstatsmsgcode2")]
        string ServiceIpStr { get; set; }
        string ServicegroupEffectiveState { get; set; }
        string MonitorWeight { get; set; } //[JsonPropertyName("monweight")]
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