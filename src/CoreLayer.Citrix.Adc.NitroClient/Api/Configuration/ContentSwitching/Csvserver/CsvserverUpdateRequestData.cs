using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public abstract class CsvserverUpdateRequestData : INitroRequestData
    {
        public string Name { get; }

        public CsvserverUpdateRequestData(string csvServerName)
        {
            Name = csvServerName;
        }
        
        public string IpV46 { get; set; }
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public string StateUpdate { get; set; }
        public double? CltTimeout { get; set; }
        public string Precedence { get; set; }
        public string CaseSensitive { get; set; }
        public string BackupVServer { get; set; }
        public string SoMethod { get; set; } 
        public string SoPersistence { get; set; } 
        public double? SoPersistenceTimeout { get; set; }
        public double? SoThreshold { get; set; } 
        public string SoBackupAction { get; set; }
        public string DownstateFlush { get; set; }
        public string DisablePrimaryOnDown { get; set; }
        public string ListenPolicy { get; set; }
        public double? ListenPriority { get; set; }
        public string Comment { get; set; }
        public string L2Conn { get; set; }
        public string AppFlowLog { get; set; }
        public string NetProfile { get; set; }
        public string IcmpvsrResponse { get; set; } 
        public string RhiState { get; set; }
        public string DnsRecordType { get; set; }
        public double? PersistenceId { get; set; }
        public string DomainName { get; set; }
        public double? Ttl { get; set; }
        public string BackupIp { get; set; }
        public string CookieDomain { get; set; }
        public double? CookieTimeout { get; set; }
        public double? SiteDomainTtl { get; set; }
    }
}