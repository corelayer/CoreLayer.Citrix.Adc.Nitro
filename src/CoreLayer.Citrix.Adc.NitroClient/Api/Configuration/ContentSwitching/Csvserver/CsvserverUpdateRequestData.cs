using System.Text.Json.Serialization;
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
        
        [JsonPropertyName("ipv46")]public string IpVersion4Or6Value { get; set; }
        public string IpPattern { get; set; }
        public string IpMask { get; set; }
        public string StateUpdate { get; set; }
        [JsonPropertyName("clttimeout")]public double? ClientTimeout { get; set; }
        public string Precedence { get; set; }
        public string CaseSensitive { get; set; }
        [JsonPropertyName("backupvserver")]public string BackupVirtualServer { get; set; }
        [JsonPropertyName("somethod")]public string SpillOverMethod { get; set; } 
        [JsonPropertyName("sopersistence")]public string SpillOverPersistence { get; set; } 
        [JsonPropertyName("sopersistencetimeout")]public double? SpillOverPersistenceTimeout { get; set; }
        [JsonPropertyName("sothreshold")]public double? SpillOverThreshold { get; set; } 
        [JsonPropertyName("sobackupaction")]public string SpillOverBackupAction { get; set; }
        public string DownstateFlush { get; set; }
        public string DisablePrimaryOnDown { get; set; }
        public string ListenPolicy { get; set; }
        public double? ListenPriority { get; set; }
        public string Comment { get; set; }
        [JsonPropertyName("l2conn")]public string UseL2ConnectionParameters { get; set; }
        [JsonPropertyName("appflowlog")]public string AppFlowLogging { get; set; }
        public string NetProfile { get; set; }
        public string IcmpvsrResponse { get; set; } 
        [JsonPropertyName("rhistate")]public string RouteHostInjectionState { get; set; }
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