using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.LoadBalancing.Lbvserver.LbvserverUpdateRequestDatas
{
    public abstract class LbvserverUpdateRequestData : INitroRequestData
    {
        public string Name { get; }
        public LbvserverUpdateRequestData(string lbvserverName)
        {
            Name = lbvserverName;
        }
        
        //public string IpV46 { get; set; } 
        //public string IpPattern { get; set; }
        //public string IpMask { get; set; }
        public double? Weight { get; set; }
        public string ServiceName { get; set; }
        public double? Range { get; set; }
        //public string PersistenceType { get; set; }
        public double? Timeout { get; set; }
        public string PersistenceBackup { get; set; }
        public double? BackupPersistenceTimeout { get; set; }
        public string LbMethod { get; set; } 
        public double? HashLength { get; set; }
        public string NetMask { get; set; } 
        public double? V6NetMaskLen { get; set; }
        public string BackupLbMethod { get; set; }
        public string CookieName { get; set; }
        public string Rule { get; set; }
        public string ListenPolicy { get; set; } 
        public double? ListenPriority { get; set; }
        public string ResRule { get; set; }
        public string PersistMask { get; set; }
        public double? V6PersistMaskLen { get; set; }
        public string Pq { get; set; }
        public string Sc { get; set; }
        //public string RtspNat { get; set; } 
        public string M { get; set; }
        public double? TosId { get; set; }
        //public double? DataLength { get; set; }
        //public double? DataOffset { get; set; }
        public string SessionLess { get; set; }
        public string TrofsPersistence { get; set; }
        //public string ConnFailover { get; set; }
        //public string RedirUrl { get; set; }
        //public string Cacheable { get; set; }
        public double? CltTimeout { get; set; } 
        public string SoMethod { get; set; }
        public string SoPersistence { get; set; } 
        public double? SoPersistenceTimeout { get; set; }
        public double? HealthThreshold { get; set; } 
        public double? SoThreshold { get; set; }
        public string SoBackupAction { get; set; }
        //public string RedirectPortRewrite { get; set; }
        public string DownStateFlush { get; set; }
        public string DisablePrimaryOnDown { get; set; }
        //public string InsertVserverIpPort { get; set; }
        //public string VipHeader { get; set; }
        //public string AuthenticationHost { get; set; }
        //public string Authentication { get; set; } 
        //public string Authn401 { get; set; }
        //public string AuthnVsName { get; set; }
        public string Push { get; set; }
        public string PushVserver { get; set; }
        public string PushLabel { get; set; }
        public string PushMultiClients { get; set; }
        //public string TcpProfileName { get; set; }
        //public string HttpProfileName { get; set; } 
        //public string DbProfileName { get; set; }
        public string Comment { get; set; }
        public string L2Conn { get; set; }
        //public string OracleServerVersion { get; set; }
        //public string MsSqlServerVersion { get; set; }
        //public double? MySqlProtocolVersion { get; set; }
        //public string MySqlServerVersion { get; set; }
        //public double? MySqlCharacterSet { get; set; }
        //public double? MySqlServerCapabilities { get; set; }
        public string AppFlowLog { get; set; } 
        public string NetProfile { get; set; } 
        public string IcmpVsrResponse { get; set; }
        public string RhiState { get; set; }
        public double? NewServiceRequest { get; set; } 
        public string NewServiceRequestUnit { get; set; } 
        public double? NewServiceRequestIncrementInterval { get; set; }
        public double? MinAutoScaleMembers { get; set; } 
        public double? MaxAutoScaleMembers { get; set; }
        public double[] PersistAvpno { get; set; }
        //public string SkipPersistency { get; set; }
        //public string AuthnProfile { get; set; }
        public string MacModerateInVlan { get; set; }
        //public string Dbslb { get; set; }
        //public string Dns64 { get; set; }
        //public string Bypassaaaa { get; set; }
        //public string RecursionAvailable { get; set; }
        public string ProcessLocal { get; set; }
        //public string DnsProfileName { get; set; }
        public string LbProfileName { get; set; }
        //public int? RedirectFromPort { get; set; }
        //public string HttpsRedirectUrl { get; set; }
        //public string RetainConnectionsOnCluster { get; set; }
    }
}