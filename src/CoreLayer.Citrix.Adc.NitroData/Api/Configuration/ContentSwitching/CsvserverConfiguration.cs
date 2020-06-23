using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching
{
    public class CsvserverConfiguration //: ICsvserverConfiguration
    {
        public string Name { get; set; }
        [JsonPropertyName("td")]public string TrafficDomain { get; set; }
        public string ServiceType { get; set; }
        [JsonPropertyName("ipv46")]public string IpVersion4Or6 { get; set; }
        public string TargetType { get; set; }
        public string DnsRecordType { get; set; }
        public string PersistenceId { get; set; }
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public string Range { get; set; }
        public int? Port { get; set; }
        public string State { get; set; }
        public string StateUpdate { get; set; }
        public string Cacheable { get; set; }
        public string RedirectUrl { get; set; }
        [JsonPropertyName("clttimeout")]public string ClientTimeout { get; set; }
        public string Precedence { get; set; }
        public string CaseSensitive { get; set; }
        [JsonPropertyName("somethod")]public string SpillOverMethod { get; set; }
        [JsonPropertyName("sopersistence")]public string SpillOverPersistence { get; set; }
        [JsonPropertyName("sopersistencetimeout")]public string SpillOverPersistenceTimeout { get; set; }
        [JsonPropertyName("sothreshold")]public string SpillOverThreshold { get; set; }
        [JsonPropertyName("sobackupaction")]public string SpillOverBackupAction { get; set; }
        public string RedirectPortRewrite { get; set; }
        public string DownStateFlush { get; set; }
        [JsonPropertyName("backupvserver")]public string BackupVirtualServer { get; set; }
        public string DisablePrimaryOnDown { get; set; }
        [JsonPropertyName("insertvserveripport")]public string InsertVirtualServerIpPort { get; set; }
        [JsonPropertyName("vipheader")]public string VirtualServerIpAndPortHeader { get; set; }
        [JsonPropertyName("rtspnat")]public string RealTimeStreamingProtocolNetworkAddressTranslation { get; set; }
        public string AuthenticationHost { get; set; }
        public string Authentication { get; set; }
        public string ListenPolicy { get; set; }
        public string ListenPriority { get; set; }
        [JsonPropertyName("authn401")]public string AuthenticationWithHttp401 { get; set; }
        [JsonPropertyName("authnvsname")]public string AuthenticationVirtualServerName { get; set; }
        public string Push { get; set; }
        [JsonPropertyName("pushvserver")]public string PushVirtualServer { get; set; }
        public string PushLabel { get; set; }
        public string PushMultiClients { get; set; }
        public string TcpProfileName { get; set; }
        public string HttpProfileName { get; set; }
        public string DbProfileName { get; set; }
        public string OracleServerVersion { get; set; }
        public string Comment { get; set; }
        public string MsSqlServerVersion { get; set; }
        [JsonPropertyName("l2conn")]public string L2ConnectionParameters { get; set; }
        public string MySqlProtocolVersion { get; set; }
        public string MySqlServerVersion { get; set; }
        public string MySqlCharacterSet { get; set; }
        public string MySqlServerCapabilities { get; set; }
        [JsonPropertyName("appflowlog")]public string AppFlowLogging { get; set; }
        public string NetProfile { get; set; }
        [JsonPropertyName("icmpvsrresponse")]public string IcmpVirtualServerResponse { get; set; } //todo
        [JsonPropertyName("rhistate")]public string RouteHostInjectionState { get; set; }
        [JsonPropertyName("authnprofile")]public string AuthenticationProfile { get; set; }
        public string DnsProfileName { get; set; }
        public string DomainName { get; set; }
        [JsonPropertyName("ttl")]public double? Ttl { get; set; } //todo
        public string BackupIp { get; set; }
        public string CookieDomain { get; set; }
        public double? CookieTimeout { get; set; }
        public double? SiteDomainTtl { get; set; } //ttl
        public string NewName { get; set; }
        public string Ip { get; set; }
        public string Value { get; set; }
        [JsonPropertyName("ngname")]public string NodeGroupName { get; set; }
        public string Type { get; set; }
        [JsonPropertyName("curstate")]public string CurrentState { get; set; }
        [JsonPropertyName("sc")]public string SureConnect { get; set; }
        public int? Status { get; set; }
        public string CacheType { get; set; }
        public string Redirect { get; set; }
        public string HomePage { get; set; }
        [JsonPropertyName("dnsvservername")]public string DnsVirtualServerName { get; set; }
        public string Domain { get; set; }
        public string PolicyName { get; set; }
        public string ServiceName { get; set; }
        public string Weight { get; set; }
        [JsonPropertyName("cachevserver")]public string CacheVirtualServer { get; set; }
        [JsonPropertyName("targetvserver")]public string TargetVirtualServer { get; set; }
        public string Priority { get; set; }
        public string Url { get; set; }
        public string GoToPriorityExpression { get; set; }
        public string BindPoint { get; set; }
        public bool? Invoke { get; set; }
        public string LabelType { get; set; }
        public string LabelName { get; set; }
        [JsonPropertyName("gt2gb")]public string GreaterThan2GigaBytes { get; set; }
        public string StateChangeTimeSec { get; set; }
        public string StateChangeTimeMSec { get; set; }
        public string TicksSinceLastStateChange { get; set; }
        public string RuleType { get; set; }
        [JsonPropertyName("lbvserver")]public string LoadBalancingVirtualServer { get; set; }
        [JsonPropertyName("targetlbvserver")]public string TargetLoadBalancingVirtualServer { get; set; }
        [JsonPropertyName("__count")]public double? Count { get; set; }
    }
}