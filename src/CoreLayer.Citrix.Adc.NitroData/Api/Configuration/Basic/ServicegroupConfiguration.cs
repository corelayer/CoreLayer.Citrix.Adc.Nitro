using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServicegroupConfiguration : IServicegroupConfiguration
    {
        public string ServicegroupName { get; set; }
        public string ServiceType { get; set; }
        public string CacheType { get; set; }
        public string Td { get; set; }
        public string MaxClient { get; set; }
        public string MaxReq { get; set; }
        public string Cacheable { get; set; }
        public string Cip { get; set; }
        public string CipHeader { get; set; }
        public string Usip { get; set; }
        public string PathMonitor { get; set; }
        public string PathMonitorIndv { get; set; }
        public string UseProxyPort { get; set; }
        public string HealthMonitor { get; set; }
        public string Sc { get; set; }
        public string Sp { get; set; }
        public string RtspSessionIdRemap { get; set; }
        public double? CltTimeout { get; set; }
        public double? SvrTimeout { get; set; }
        public string Cka { get; set; }
        public string TcpB { get; set; }
        public string Cmp { get; set; }
        public string MaxBandWidth { get; set; }
        public string MonThreshold { get; set; }
        public string State { get; set; }
        public string DownStateFlush { get; set; }
        public string TcpProfileName { get; set; }
        public string HttpProfileName { get; set; }
        public string Comment { get; set; }
        public string AppFlowLog { get; set; }
        public string NetProfileName { get; set; }
        public string AutoScale { get; set; }
        public int? MemberPort { get; set; }
        public string MonConnectionsClose { get; set; }
        public string ServerName { get; set; }
        public int? Port { get; set; }
        public string Weight { get; set; }
        public string CustomServerId { get; set; }
        public string ServerId { get; set; }
        public string HashId { get; set; }
        [JsonPropertyName("monitor_name_svc")]public string MonitorNameSvc { get; set; }
        [JsonPropertyName("dup_weight")]public string DupWeight { get; set; }
        public int? RiseApbrStatsMsgCode { get; set; }
        public double? Delay { get; set; }
        public string Graceful { get; set; }
        public bool? IncludeMembers { get; set; }
        public string NewName { get; set; }
        public int? NumOfConnections { get; set; }
        public bool? ServiceConfType { get; set; }
        public string Value { get; set; }
        public string SvrState { get; set; }
        public string Ip { get; set; }
        public int? MonStatCode { get; set; }
        public int? MonStatParam1 { get; set; }
        public int? MonStatParam2 { get; set; }
        public int? MonStatParam3 { get; set; }
        public string StateChangeTimeMSec { get; set; }
        public string StateUpdateReason { get; set; }
        public string ClMonOwner { get; set; }
        public string ClMonView { get; set; }
        public string GroupCount { get; set; }
        public int? RiseApbrStatsMsgCode2 { get; set; }
        public string ServiceIpStr { get; set; }
        public string ServicegroupEffectiveState { get; set; }
        public string MonWeight { get; set; }
        public string MonitorState { get; set; }
        public string MonitorTotalProbes { get; set; }
        public string MonitorTotalFailedProbes { get; set; }
        public string MonitorCurrentFailedProbes { get; set; }
        public string StateChangeTimeSec { get; set; }
        public string NoDefaultBindings { get; set; }
        public string NameServer { get; set; }
        public double? Dbsttl { get; set; }
        public string SvcItmactscvs { get; set; }
        public string SvcitmBoundSvcs { get; set; }
        public string ResponseTime { get; set; }
        public string MonUserStatusMesg { get; set; }
        public double? Count { get; set; }
    }
}