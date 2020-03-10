namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.ContentSwitching
{
    public interface ICsvserverConfiguration
    {
        string Name { get; set; }
        string TrafficDomain { get; set; } //[JsonPropertyName("td")]
        string ServiceType { get; set; }
        string IpVersion4Or6 { get; set; } //[JsonPropertyName("ipv46")]
        string TargetType { get; set; }
        string DnsRecordType { get; set; }
        string PersistenceId { get; set; }
        string IpPattern { get; set; }
        string IpMask { get; set; }
        string Range { get; set; }
        int? Port { get; set; }
        string State { get; set; }
        string StateUpdate { get; set; }
        string Cacheable { get; set; }
        string RedirectUrl { get; set; }
        string ClientTimeout { get; set; } //[JsonPropertyName("clttimeout")]
        string Precedence { get; set; }
        string CaseSensitive { get; set; }
        string SpillOverMethod { get; set; } //[JsonPropertyName("somethod")]
        string SpillOverPersistence { get; set; } //[JsonPropertyName("sopersistence")]
        string SpillOverPersistenceTimeout { get; set; } //[JsonPropertyName("sopersistencetimeout")]
        string SpillOverThreshold { get; set; } //[JsonPropertyName("sothreshold")]
        string SpillOverBackupAction { get; set; } //[JsonPropertyName("sobackupaction")]
        string RedirectPortRewrite { get; set; }
        string DownStateFlush { get; set; }
        string BackupVirtualServer { get; set; } //[JsonPropertyName("backupvserver")]
        string DisablePrimaryOnDown { get; set; } 
        string InsertVserverIpPort { get; set; }
        string VirtualIpHeader { get; set; } //[JsonPropertyName("vipheader")]
        string RtspNetworkAddressTranslation { get; set; } //[JsonPropertyName("rtspnat")]
        string AuthenticationHost { get; set; }
        string Authentication { get; set; }
        string ListenPolicy { get; set; }
        string ListenPriority { get; set; }
        string Authentication401 { get; set; } //[JsonPropertyName("Authn401")]
        string AuthenticationVirtualServerName { get; set; } //[JsonPropertyName("authnvsname")]
        string Push { get; set; }
        string PushVirtualServer { get; set; } //[JsonPropertyName("pushvserver")]
        string PushLabel { get; set; }
        string PushMultiClients { get; set; }
        string TcpProfileName { get; set; }
        string HttpProfileName { get; set; }
        string DbProfileName { get; set; }
        string OracleServerVersion { get; set; }
        string Comment { get; set; }
        string MsSqlServerVersion { get; set; }
        string UseL2ParametersConnections { get; set; } //[JsonPropertyName("l2conn")]
        string MySqlProtocolVersion { get; set; }
        string MySqlServerVersion { get; set; }
        string MySqlCharacterSet { get; set; }
        string MySqlServerCapabilities { get; set; }
        string AppFlowLogging { get; set; } //[JsonPropertyName("appflowlog")]
        string NetProfile { get; set; }
        string IcmpVsrResponse { get; set; } //[JsonPropertyName("icmpvsrresponse")]
        string RouteHostInjectedState { get; set; } //[JsonPropertyName("rhistate")]
        string AuthenticationProfile { get; set; } //[JsonPropertyName("authnprofile")]
        string DnsProfileName { get; set; }
        string DomainName { get; set; }
        double? TimeToLive { get; set; } //[JsonPropertyName("ttl")]
        string BackupIp { get; set; }
        string CookieDomain { get; set; }
        double? CookieTimeout { get; set; }
        double? SiteDomainTimeToLive { get; set; } //[JsonPropertyName("sitedomainttl")]
        string NewName { get; set; }
        string Ip { get; set; }
        string Value { get; set; }
        string NodegroupName { get; set; } //[JsonPropertyName("ngname")]
        string Type { get; set; }
        string CurrentState { get; set; } //[JsonPropertyName("curstate")]
        string SureConnect { get; set; } //[JsonPropertyName("sc")]
        int? Status { get; set; }
        string CacheType { get; set; }
        string Redirect { get; set; }
        string HomePage { get; set; }
        string DnsVserverName { get; set; }
        string Domain { get; set; }
        string PolicyName { get; set; }
        string ServiceName { get; set; }
        string Weight { get; set; }
        string CacheVserver { get; set; }
        string TargetVserver { get; set; }
        string Priority { get; set; }
        string Url { get; set; }
        string GoToPriorityExpression { get; set; }
        string BindPoint { get; set; }
        bool? Invoke { get; set; }
        string LabelType { get; set; }
        string LabelName { get; set; }
        string GreaterThan2Gb { get; set; } //[JsonPropertyName("gt2gb")]
        string StateChangeTimeSec { get; set; }
        string StateChangeTimeMSec { get; set; }
        string TicksSinceLastStateChange { get; set; }
        string RuleType { get; set; }
        string LbvServer { get; set; }
        string TargetLbvserver { get; set; }
        double? Count { get; set; } //[JsonPropertyName("__count")]
    }
}