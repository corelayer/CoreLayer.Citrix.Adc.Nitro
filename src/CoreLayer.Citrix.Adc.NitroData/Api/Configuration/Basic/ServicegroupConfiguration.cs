using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServicegroupConfiguration //: IServicegroupConfiguration
    {
        public string ServicegroupName { get; set; }
        public string ServiceType { get; set; }
        public string CacheType { get; set; }
        [JsonPropertyName("td")]public string TrafficDomain { get; set; }
        public string MaxClient { get; set; }
        [JsonPropertyName("maxreq")]public string MaxRequests { get; set; }
        public string Cacheable { get; set; }
        [JsonPropertyName("cip")]public string InjectClientIp { get; set; }
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
        [JsonPropertyName("monitor_name_svc")]public string MonitorNameService { get; set; }
        [JsonPropertyName("dup_weight")]public string DuplicateWeight { get; set; }
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
        [JsonPropertyName("monstatparam1")]public int? MonitorStatParameter1 { get; set; }
        [JsonPropertyName("monstatparam2")]public int? MonitorStatParameter2 { get; set; }
        [JsonPropertyName("monstatparam3")]public int? MonitorStatParameter3 { get; set; }
        public string StateChangeTimeMSec { get; set; }
        public string StateUpdateReason { get; set; }
        [JsonPropertyName("clmonowner")]public string MonitorOwner { get; set; }
        [JsonPropertyName("clmonview")]public string MonitorView { get; set; }
        public string GroupCount { get; set; }
        [JsonPropertyName("riseapbrstatsmsgcode2")]public int? RiseApbrStatusMessageCode2 { get; set; }
        [JsonPropertyName("serviceipstr")]public string ServiceIp { get; set; }
        public string ServicegroupEffectiveState { get; set; }
        [JsonPropertyName("monweight")]public string MonitorWeight { get; set; }
        public string MonitorState { get; set; }
        public string MonitorTotalProbes { get; set; }
        public string MonitorTotalFailedProbes { get; set; }
        public string MonitorCurrentFailedProbes { get; set; }
        public string StateChangeTimeSec { get; set; }
        public string NoDefaultBindings { get; set; }
        public string NameServer { get; set; }
        [JsonPropertyName("dbsttl")]public double? DomainBasedServiceTtl { get; set; }
        [JsonPropertyName("svcitmactsvcs")]public string ServiceItemActive { get; set; }
        [JsonPropertyName("svcitmboundsvcs")]public string ServiceItemBound { get; set; }
        public string ResponseTime { get; set; }
        [JsonPropertyName("monuserstatusmesg")]public string MonitorUserStatusMessage { get; set; }
        [JsonPropertyName("__count")]public double? Count { get; set; }
    }
}