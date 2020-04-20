
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
        string MaxReq { get; set; }
        string Cacheable { get; set; }
        string Cip { get; set; } 
        string CipHeader { get; set; } 
        string Usip { get; set; } 
        string PathMonitor { get; set; }
        string PathMonitorIndv { get; set; }
        string UseProxyPort { get; set; }
        string Sc { get; set; } 
        string Sp { get; set; } 
        string RtspSessionIdRemap { get; set; }
        double? CltTimeout { get; set; } 
        double? SvrTimeout { get; set; } 
        string CustomServerId { get; set; }
        string ServerId { get; set; }
        string Cka { get; set; } 
        string TcpB { get; set; } 
        string Cmp { get; set; } 
        string MaxBandwidth { get; set; }
        string AccessDown { get; set; }
        string MonThreshold { get; set; } 
        string State { get; set; }
        string DownStateFlush { get; set; }
        string TcpProfileName { get; set; }
        string HttpProfileName { get; set; }
        double? HashId { get; set; }
        string Comment { get; set; }
        string AppFlowLog { get; set; }
        string NetProfile { get; set; }
        string Td { get; set; } 
        string ProcessLocal { get; set; }
        string DnsProfileName { get; set; }
        string MonConnectionClose { get; set; } 
        string IpAddress { get; set; }
        double? Weight { get; set; }
        string MonitorNameService { get; set; } //[JsonPropertyName("monitor_name_svc")]
        int? RiseApbrStatsMsgCode { get; set; }
        double? Delay { get; set; }
        string Graceful { get; set; }
        bool? All { get; set; }
        bool? Internal { get; set; }
        string NewName { get; set; }
        int? NumOfConnections { get; set; } 
        string PolicyName { get; set; }
        bool? ServiceConfType { get; set; } 
        string ServiceConfType2 { get; set; } 
        string Value { get; set; }
        string Gslb { get; set; } 
        string DupState { get; set; } //[JsonPropertyName("dup_state")]
        string DupWeight { get; set; } //[JsonPropertyName("dup_weight")]
        string PublicIp { get; set; }
        int? PublicPort { get; set; }
        string SvrState { get; set; } 
        string MonitorState { get; set; } //[JsonPropertyName("monitor_state")]
        int? MonStatCode { get; set; } 
        string LastResponse { get; set; }
        string ResponseTime { get; set; }
        int? RiseApbrStatsMsgCode2 { get; set; } 
        int? MonStatParam1 { get; set; }
        int? MonStatParam2 { get; set; }
        int? MonStatParam3 { get; set; }
        string StateChangeTimeSec { get; set; }
        string StateChangeTimeMSec { get; set; }
        string TicksSinceLastStateChange { get; set; }
        string StateUpdateReason { get; set; }
        string ClMonOwner { get; set; }
        string ClMonView { get; set; } 
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