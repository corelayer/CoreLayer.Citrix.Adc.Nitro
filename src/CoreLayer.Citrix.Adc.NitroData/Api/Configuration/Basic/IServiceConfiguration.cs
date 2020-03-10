
namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public interface IServiceConfiguration 
    {
        string Name { get; set; }
        string Ip { get; set; }
        string ServerName { get; set; }
        string ServiceType { get; set; }
        int? Port { get; set; }
        int? ClearTextPort { get; set; }
        string CacheType { get; set; }
        string MaxClient { get; set; }
        string HealthMonitor { get; set; }
        string MaxRequests { get; set; } //[JsonPropertyName("MaxReq")]
        string Cacheable { get; set; }
        string ClientIp { get; set; } //[JsonPropertyName("cip")]
        string ClientIpHeader { get; set; } //[JsonPropertyName("cipheader")]
        string UseSourceIp { get; set; } //[JsonPropertyName("usip")]
        string PathMonitor { get; set; }
        string PathMonitorIndividual { get; set; }//[JsonPropertyName("pathmonitorindv")]
        string UseProxyPort { get; set; }
        string SureConnect { get; set; } //[JsonPropertyName("sc")]
        string SurgeProtection { get; set; } //[JsonPropertyName("sp")]
        string RtspSessionIdRemap { get; set; }
        double? ClientTimeout { get; set; } //[JsonPropertyName("clttimeout")]
        double? ServerTimeout { get; set; } //[JsonPropertyName("svrtimeout")]
        string CustomServerId { get; set; }
        string ServerId { get; set; }
        string ClientKeepAlive { get; set; } //[JsonPropertyName("cka")]
        string TcpBuffering { get; set; } //[JsonPropertyName("tcpb")]
        string Compression { get; set; } //[JsonPropertyName("cmp")]
        string MaxBandwidth { get; set; }
        string AccessDown { get; set; }
        string MonitorWeightThreshold { get; set; } //[JsonPropertyName("monthreshold")]
        string State { get; set; }
        string DownStateFlush { get; set; }
        string TcpProfileName { get; set; }
        string HttpProfileName { get; set; }
        double? HashId { get; set; }
        string Comment { get; set; }
        string AppFlowLog { get; set; }
        string NetworkProfile { get; set; } //[JsonPropertyName("netprofile")]
        string TrafficDomain { get; set; } //[JsonPropertyName("td")]
        string ProcessLocal { get; set; }
        string DnsProfileName { get; set; }
        string MonitoringConnectionsClose { get; set; } //[JsonPropertyName("monconnectionclose")]
        string IpAddress { get; set; }
        double? Weight { get; set; }
        string MonitorNameService { get; set; } //[JsonPropertyName("monitor_name_svc")]
        int? RiseApbrStatusMessageCode { get; set; } //[JsonPropertyName("riseapbrstatsmsgcode")]
        double? Delay { get; set; }
        string Graceful { get; set; }
        bool? All { get; set; }
        bool? Internal { get; set; }
        string NewName { get; set; }
        int? NumberOfConnections { get; set; } //[JsonPropertyName("numofconnections")]
        string PolicyName { get; set; }
        bool? ServiceConfigurationType { get; set; } //[JsonPropertyName("serviceconftype")]
        string ServiceConfigurationType2 { get; set; } //[JsonPropertyName("serviceconftype2")]
        string Value { get; set; }
        string GlobalServerLoadBalancing { get; set; } //[JsonPropertyName("gslb")]
        string DupState { get; set; } //[JsonPropertyName("dup_state")]
        string DupWeight { get; set; } //[JsonPropertyName("dup_weight")]
        string PublicIp { get; set; }
        int? PublicPort { get; set; }
        string ServerState { get; set; } //[JsonPropertyName("svrstate")]
        string MonitorState { get; set; } //[JsonPropertyName("monitor_state")]
        int? MonitorStatCode { get; set; } //[JsonPropertyName("monstatcode")]
        string LastResponse { get; set; }
        string ResponseTime { get; set; }
        int? RiseApbrStatusMessageCode2 { get; set; } //[JsonPropertyName("riseapbrstatsmsgcode2")]
        int? MonStatParam1 { get; set; }
        int? MonStatParam2 { get; set; }
        int? MonStatParam3 { get; set; }
        string StateChangeTimeSec { get; set; }
        string StateChangeTimeMSec { get; set; }
        string TicksSinceLastStateChange { get; set; }
        string StateUpdateReason { get; set; }
        string ClMonitorOwner { get; set; } //[JsonPropertyName("clmonowner")]
        string ClMonitorView { get; set; } //[JsonPropertyName("clmonview")]
        string ServiceIpStr { get; set; }
        string OracleServerVersion { get; set; }
        string FailedProbes { get; set; }
        string TotalProbes { get; set; }
        string TotalFailedProbes { get; set; }
        string MonitorTotalProbes { get; set; }
        string MonitorTotalFailedProbes { get; set; }
        string MonitorCurrentFailedProbes { get; set; }
        bool? Passive { get; set; }
        double? Count { get; set; }
    }
}