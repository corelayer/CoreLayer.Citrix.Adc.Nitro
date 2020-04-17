using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic.Servicegroup
{
    public class ServicegroupConfiguration : IServicegroupConfiguration
    {
        public string ServicegroupName { get; set; }
        public string ServiceType { get; set; }
        public string CacheType { get; set; }
        [JsonPropertyName("td")]public string TrafficDomain { get; set; }
        public string MaxClient { get; set; }
        [JsonPropertyName("maxreq")]public string MaxRequests { get; set; }
        public string Cacheable { get; set; }
        [JsonPropertyName("cip")]public string ClientIp { get; set; }
        [JsonPropertyName("cipheader")]public string ClientIpHeader { get; set; }
        [JsonPropertyName("usip")]public string UseSourceIp { get; set; }
        public string PathMonitor { get; set; }
        [JsonPropertyName("pathmonitorindv")]public string PathMonitorIndividual { get; set; }
        public string UseProxyPort { get; set; }
        public string HealthMonitor { get; set; }
        [JsonPropertyName("sc")]public string SureConnect { get; set; }
        [JsonPropertyName("sp")]public string SurgeProtection { get; set; }
        public string RtspSessionIdRemap { get; set; }
        [JsonPropertyName("clttimeout")]public double? ClientTimeout { get; set; }
        [JsonPropertyName("svrtimeout")]public double? ServerTimeout { get; set; }
        [JsonPropertyName("cka")]public string ClientKeepAlive { get; set; }
        [JsonPropertyName("tcpb")]public string TcpBuffering { get; set; }
        [JsonPropertyName("cmp")]public string Compression { get; set; }
        public string MaxBandWidth { get; set; }
        [JsonPropertyName("monthreshold")]public string MonitorWeightThreshold { get; set; }
        public string State { get; set; }
        public string DownStateFlush { get; set; }
        public string TcpProfileName { get; set; }
        public string HttpProfileName { get; set; }
        public string Comment { get; set; }
        [JsonPropertyName("appflowlog")]public string AppFlowLogging { get; set; }
        [JsonPropertyName("netprofile")]public string NetworkProfileName { get; set; }
        public string AutoScale { get; set; }
        public int? MemberPort { get; set; }
        [JsonPropertyName("monconnectionclose")]public string MonitoringConnectionsClose { get; set; }
        public string ServerName { get; set; }
        public int? Port { get; set; }
        public string Weight { get; set; }
        public string CustomServerId { get; set; }
        public string ServerId { get; set; }
        public string HashId { get; set; }
        [JsonPropertyName("monitor_name_svc")]public string MonitorNameSvc { get; set; }
        [JsonPropertyName("dup_weight")]public string DupWeight { get; set; }
        [JsonPropertyName("riseapbrstatsmsgcode")]public int? RiseApbrStatusMessageCode { get; set; }
        public double? Delay { get; set; }
        public string Graceful { get; set; }
        public bool? IncludeMembers { get; set; }
        public string NewName { get; set; }
        [JsonPropertyName("numofconnections")]public int? NumberOfConnections { get; set; }
        [JsonPropertyName("serviceconftype")]public bool? ServiceConfigurationType { get; set; }
        public string Value { get; set; }
        [JsonPropertyName("svrstate")]public string ServerState { get; set; }
        public string Ip { get; set; }
        [JsonPropertyName("monstatcode")]public int? MonitorStatCode { get; set; }
        [JsonPropertyName("monstatparam1")]public int? MonitorStatParam1 { get; set; }
        [JsonPropertyName("monstatparam2")]public int? MonitorStatParam2 { get; set; }
        [JsonPropertyName("monstatparam3")]public int? MonitorStatParam3 { get; set; }
        public string StateChangeTimeMSec { get; set; }
        public string StateUpdateReason { get; set; }
        [JsonPropertyName("clmonowner")]public string ClMonitorOwner { get; set; }
        [JsonPropertyName("clmonview")]public string ClMonitorView { get; set; }
        public string GroupCount { get; set; }
        [JsonPropertyName("riseapbrstatsmsgcode2")]public int? RiseApbrStatusMessageCode2 { get; set; }
        public string ServiceIpStr { get; set; }
        public string ServicegroupEffectiveState { get; set; }
        [JsonPropertyName("monweight")]public string MonitorWeight { get; set; }
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