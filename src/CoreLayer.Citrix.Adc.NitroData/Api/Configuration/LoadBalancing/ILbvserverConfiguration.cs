namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.LoadBalancing
{
    public interface ILbvserverConfiguration 
    {
        string Name { get; set; }
        string ServiceType { get; set; }
        string IpVersion4Or6 { get; set; } //[jsonname: ipv46]
        string IpPattern { get; set; }
        string IpMask { get; set; }
        int? Port { get; set; }
        string Range { get; set; }
        string PersistenceType { get; set; }
        double? Timeout { get; set; }
        string PersistenceBackup { get; set; }
        double? BackupPersistenceTimeout { get; set; }
        string LoadBalancingMethod { get; set; } //[JsonPropertyName("LbMethod")]
        string HashLength { get; set; }
        string NetMask { get; set; }
        double? V6NetMaskLen { get; set; }
        string BackupLbMethod { get; set; }
        string CookieName { get; set; }
        string TrafficRule { get; set; } //[JsonPropertyName("Rule")]
        string ListenPolicy { get; set; }
        string ListenPriority { get; set; }
        string ResponseRule { get; set; } //[JsonPropertyName("ResRule")]
        string PersistMask { get; set; }
        string V6PersistMaskLen { get; set; }
        string PriorityQueuing { get; set; } //[JsonPropertyName("Pq")]
        string SureConnect { get; set; } //[JsonPropertyName("Sc")]
        string RtspNetworkAddressTranslation { get; set; } //[JsonPropertyName("RtspNat")]
        string LoadBalancingRedirectMode { get; set; } //[JsonPropertyName("M")]
        string TosId { get; set; }
        string DataLength { get; set; }
        string DataOffSet { get; set; }
        string Sessionless { get; set; }
        string TrofsPersistence { get; set; }
        string State { get; set; }
        string ConnectionFailoverMode { get; set; } //[JsonPropertyName("ConnFailover")]
        string RedirectUrl { get; set; } //[JsonPropertyName("RedirUrl")]
        string Cacheable { get; set; }
        string ClientTimeoutIdleTime { get; set; } //[JsonPropertyName("CltTimeout")]
        string SpillOverMethod { get; set; } //[JsonPropertyName("SoMethod")]
        string SpillOverPersistence { get; set; } //[JsonPropertyName("SoPersistence")]
        string SpillOverPersistenceTimeout { get; set; } //[JsonPropertyName("SoPersistenceTimeout")]
        string HealthThreshold { get; set; }
        string SpillOverThreshold { get; set; } //[JsonPropertyName("SoThreshold")]
        string SpillOverBackupAction { get; set; } //[JsonPropertyName("SoBackupAction")]
        string RedirectPortRewrite { get; set; }
        string DownstateFlush { get; set; }
        string BackupVirtualServer { get; set; } //[JsonPropertyName("BackupVserver")]
        string DisablePrimaryOnDown { get; set; }
        string InsertVirtualServerIpPort { get; set; } //[JsonPropertyName("InsertVServerIpPort")]
        string VipHeader { get; set; }
        string AuthenticationHost { get; set; }
        string Authentication { get; set; }
        string AuthenticationWith401 { get; set; } //[JsonPropertyName("Authn401")]
        string AuthenticationVirtualServerName { get; set; } //[JsonPropertyName("AuthnVsName")]
        string Push { get; set; }
        string PushVirtualServerName { get; set; } //[JsonPropertyName("PushVserver")]
        string PushLabelExpression { get; set; } //[JsonPropertyName("PushLabel")]
        string PushMultiClients { get; set; }
        string TcpProfileName { get; set; }
        string HttpProfileName { get; set; }
        string DbProfileName { get; set; }
        string Comment { get; set; }
        string UseLayer2Parameters { get; set; } //[JsonPropertyName("L2Conn")]
        string OracleServerVersion { get; set; }
        string MsSqlServerVersion { get; set; }
        string MySqlProtocolVersion { get; set; }
        string MySqlServerVersion { get; set; }
        string MySqlCharacterSet { get; set; }
        string MySqlServerCapabilities { get; set; }
        string AppFlowLogging { get; set; } //[JsonPropertyName("AppFlowLog")]
        string NetworkProfile { get; set; } //[JsonPropertyName("NetProfile")]
        string PingRequestForCommonIpResponse { get; set; } //[JsonPropertyName("IcmpVsrResponse")]
        string RouteHealthInjectionState { get; set; } //[JsonPropertyName("RhiState")]
        string NewServiceRequest { get; set; }
        string NewServiceRequestUnit { get; set; }
        string NewServiceRequestIncrementInterval { get; set; }
        string MinAutoScaleMembers { get; set; }
        string MaxAutoScaleMembers { get; set; }
        string[] PersistAvpNumber { get; set; } //[JsonPropertyName("PersistAvpNo")]
        string SkipPersistency { get; set; }
        string TrafficDomain { get; set; } //[JsonPropertyName("Td")]
        string AuthenticationProfile { get; set; } //[JsonPropertyName("AuthnProfile")]
        string MacModeRetainVlan { get; set; }
        string DatabaseSpecificLoadBalancing { get; set; } //[JsonPropertyName("DbSlb")]
        string Dns64 { get; set; }
        string BypassAaaa { get; set; }
        string RecursionAvailable { get; set; }
        string ProcessLocal { get; set; }
        string DnsProfileName { get; set; }
        string LoadBalancingProfileName { get; set; } //[JsonPropertyName("LbProfileName")]
        int? RedirectFromPort { get; set; }
        string HttpsRedirectUrl { get; set; }
        string RetainConnectionsOnCluster { get; set; }
        string Weight { get; set; }
        string DynamicWeight { get; set; }
        string ServiceName { get; set; }
        bool? RedirectUrlFlags { get; set; } //[JsonPropertyName("RedirUrlFlags")]
        string ValueSslStatus { get; set; } //[JsonPropertyName("Value")]
        string IpMapping { get; set; }
        string NodeGroupName { get; set; } //[JsonPropertyName("NgName")]
        string Type { get; set; }
        string CurrentState { get; set; } //[JsonPropertyName("CurState")]
        string EffectiveState { get; set; }
        int? Status { get; set; }
        int? LoadBalancerRoundRobinReason { get; set; } //[JsonPropertyName("LbRrReason")]
        string CacheRedirectType { get; set; } //[JsonPropertyName("Redirect")]
        string Precedence { get; set; }
        string HomePage { get; set; }
        string DnsVserverName { get; set; }
        string Domain { get; set; }
        string PolicyName { get; set; }
        string CacheVServer { get; set; }
        string Health { get; set; }
        string GoToPriorityExpression { get; set; }
        string RuleType { get; set; }
        string GroupName { get; set; }
        string CookieDomain { get; set; }
        string Map { get; set; }
        string GreaterThan2Gb { get; set; } //[JsonPropertyName("Gt2GB")]
        string ConsolidatedLeastConnection { get; set; } //[JsonPropertyName("ConsolidatedLConn")]
        string ConsolidatedLeastConnectionGlobal { get; set; } //[JsonPropertyName("ConsolidatedLConnGbl")]
        int? ThresholdValue { get; set; }
        string BindPoint { get; set; }
        bool? Invoke { get; set; }
        string LabelType { get; set; }
        string LabelName { get; set; }
        int? CookieVersion { get; set; } //[JsonPropertyName("Version")]
        string TotalServices { get; set; }
        string ActiveServices { get; set; }
        string StateChangeTimeSec { get; set; }
        string StateChangeTimeSeconds { get; set; }
        string StateChangeTimeMsec { get; set; }
        string TicksSinceLastStateChange { get; set; }
        bool? IsGlobalServerLoadBalancingVirtualServer { get; set; } //[JsonPropertyName("IsGsLb")]
        string VirtualServerDynamicConnectionSpillOverThreshold { get; set; } //[JsonPropertyName("VsvrDynConnSoThreshold")]
        string BackupVserverStatus { get; set; }
        string CacheType { get; set; }
        string Hits { get; set; }
        string PiPolicyHits { get; set; }
        string PolicySubType { get; set; }
        string VsvrBindsvcIp { get; set; }
        int? VsvrBindsvcPort { get; set; }
        string NoDefaultBindings { get; set; }
        string Priority { get; set; }

        double? Count { get; set; } //[JsonPropertyName("__count")]
    }
}