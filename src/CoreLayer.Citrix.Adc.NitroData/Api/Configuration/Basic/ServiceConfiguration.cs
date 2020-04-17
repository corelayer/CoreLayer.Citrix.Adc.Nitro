using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServiceConfiguration : IServiceConfiguration
    {
        public string Name { get; set; }
        public string Ip { get; set; }
        public string ServerName { get; set; }
        public string ServiceType { get; set; }
        public int? Port { get; set; }
        public int? ClearTextPort { get; set; }
        public string CacheType { get; set; }
        public string MaxClient { get; set; }
        public string HealthMonitor { get; set; }
        [JsonPropertyName("maxreq")]public string MaxRequests { get; set; }
        public string Cacheable { get; set; }
        [JsonPropertyName("cip")]public string ClientIp { get; set; }
        [JsonPropertyName("cipheader")]public string ClientIpHeader { get; set; }
        [JsonPropertyName("usip")]public string UseSourceIp { get; set; }
        public string PathMonitor { get; set; }
        [JsonPropertyName("pathmonitorindv")]public string PathMonitorIndividual { get; set; }
        public string UseProxyPort { get; set; }
        [JsonPropertyName("sc")]public string SureConnect { get; set; }
        [JsonPropertyName("sp")]public string SurgeProtection { get; set; }
        public string RtspSessionIdRemap { get; set; }
        [JsonPropertyName("clttimeout")]public double? ClientTimeout { get; set; }
        [JsonPropertyName("svrtimeout")]public double? ServerTimeout { get; set; }
        public string CustomServerId { get; set; }
        public string ServerId { get; set; }
        [JsonPropertyName("cka")]public string ClientKeepAlive { get; set; }
        [JsonPropertyName("tcpb")]public string TcpBuffering { get; set; }
        [JsonPropertyName("cmp")]public string Compression { get; set; }
        public string MaxBandwidth { get; set; }
        public string AccessDown { get; set; }
        [JsonPropertyName("monthreshold")]public string MonitorWeightThreshold { get; set; }
        public string State { get; set; }
        public string DownStateFlush { get; set; }
        public string TcpProfileName { get; set; }
        public string HttpProfileName { get; set; }
        public double? HashId { get; set; }
        public string Comment { get; set; }
        public string AppFlowLog { get; set; }
        [JsonPropertyName("netprofile")] public string NetworkProfile { get; set; }
        [JsonPropertyName("td")]public string TrafficDomain { get; set; }
        public string ProcessLocal { get; set; }
        public string DnsProfileName { get; set; }
        [JsonPropertyName("monconnectionclose")]public string MonitoringConnectionsClose { get; set; }
        public string IpAddress { get; set; }
        public double? Weight { get; set; }
        [JsonPropertyName("monitor_name_svc")]public string MonitorNameService { get; set; }
        [JsonPropertyName("riseapbrstatsmsgcode")]public int? RiseApbrStatusMessageCode { get; set; }
        public double? Delay { get; set; }
        public string Graceful { get; set; }
        public bool? All { get; set; }
        public bool? Internal { get; set; }
        public string NewName { get; set; }
        [JsonPropertyName("numofconnections")]public int? NumberOfConnections { get; set; }
        public string PolicyName { get; set; }
        [JsonPropertyName("serviceconftype")]public bool? ServiceConfigurationType { get; set; }
        [JsonPropertyName("serviceconftype2")]public string ServiceConfigurationType2 { get; set; }
        public string Value { get; set; }
        [JsonPropertyName("gslb")]public string GlobalServerLoadBalancing { get; set; }
        [JsonPropertyName("dup_state")]public string DupState { get; set; }
        [JsonPropertyName("dup_weight")]public string DupWeight { get; set; }
        public string PublicIp { get; set; }
        public int? PublicPort { get; set; }
        [JsonPropertyName("svrstate")]public string ServerState { get; set; }
        [JsonPropertyName("monitor_state")]public string MonitorState { get; set; }
        [JsonPropertyName("monstatcode")]public int? MonitorStatCode { get; set; }
        public string LastResponse { get; set; }
        public string ResponseTime { get; set; }
        [JsonPropertyName("riseapbrstatsmsgcode2")]public int? RiseApbrStatusMessageCode2 { get; set; }
        public int? MonStatParam1 { get; set; }
        public int? MonStatParam2 { get; set; }
        public int? MonStatParam3 { get; set; }
        public string StateChangeTimeSec { get; set; }
        public string StateChangeTimeMSec { get; set; }
        public string TicksSinceLastStateChange { get; set; }
        public string StateUpdateReason { get; set; }
        [JsonPropertyName("clmonowner")]public string ClMonitorOwner { get; set; }
        [JsonPropertyName("clmonview")]public string ClMonitorView { get; set; }
        public string ServiceIpStr { get; set; }
        public string OracleServerVersion { get; set; }
        public string FailedProbes { get; set; }
        public string TotalProbes { get; set; }
        public string TotalFailedProbes { get; set; }
        public string MonitorTotalProbes { get; set; }
        public string MonitorTotalFailedProbes { get; set; }
        public string MonitorCurrentFailedProbes { get; set; }
        public bool? Passive { get; set; }
        public string MonUserStatusMesg { get; set; }
        [JsonPropertyName("__count")]public double? Count { get; set; }
    }
}