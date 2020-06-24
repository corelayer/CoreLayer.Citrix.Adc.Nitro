using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.ContentSwitching.Csvserver
{
    public abstract class CsvserverAddRequestData : INitroRequestData
    {
        public string Name { get; }

        public CsvserverAddRequestData(string name)
        {
            Name = name;
        }
        public CsvserverAddRequestData(string name, string ip, int port)
        {
            Name = name;
            IpVersion4Or6Value = ip;
            Port = port;
        }

        public CsvserverAddRequestData(string name, string ipPattern, string ipMask, int port)
        {
            Name = name;
            IpPattern = ipPattern;
            IpMask = ipMask;
            Port = port;
        }
        public abstract string ServiceType { get; }
        [JsonPropertyName("ipv46")]public string IpVersion4Or6Value { get; }
        public int? Port { get; }
        public string IpPattern { get; }
        public string IpMask { get; }
        
        [JsonPropertyName("td")]public double? TrafficDomain { get; set; }
        public string TargetType { get; set; }
        public string DnsRecordType { get; set; }
        public double? PersistenceId { get; set; }
        public double? Range { get; set; }
        public string State { get; set; }
        public string StateUpdate { get; set; }
        //public string Cacheable { get; set; } 
        //public string RedirectUrl { get; set; } 
        [JsonPropertyName("clttimeout")]public double? ClientTimeout { get; set; }
        public string Precedence { get; set; }
        public string CaseSensitive { get; set; }
        [JsonPropertyName("somethod")]public string SpillOverMethod { get; set; } 
        [JsonPropertyName("sopersistence")]public string SpillOverPersistence { get; set; } 
        [JsonPropertyName("sopersistencetimeout")]public double? SpillOverPersistenceTimeout { get; set; }
        [JsonPropertyName("sothreshold")]public double? SpillOverThreshold { get; set; } 
        [JsonPropertyName("sobackupaction")]public string SpillOverBackupAction { get; set; }
        //public string RedirectPortRewrite { get; set; }
        public string DownstateFlush { get; set; }
        [JsonPropertyName("backupvserver")]public string BackupVirtualServer { get; set; }
        public string DisablePrimaryOnDown { get; set; }
        //public string InsertVserverIpPort { get; set; } 
        //public string VipHeader { get; set; }
        //public string Rtspnat { get; set; }
        public string ListenPolicy { get; set; }
        public double? ListenPriority { get; set; }
        //public string AuthenticationHost { get; set; } 
        //public string Authentication { get; set; }
        //public string Authn401 { get; set; }
        //public string AuthnVsName { get; set; }
        //public string Push { get; set; }
        //public string PushVserver { get; set; }
        //public string PushLabel { get; set; }
        //public string PushMulticlients { get; set; }
        //public string TcpProfileName { get; set; }
        //public string HttpProfileName { get; set; }
        //public string DbProfileName { get; set; }
        //public string OracleServerVersion { get; set; }
        public string Comment { get; set; }
        //public string MsSqlServerVersion { get; set; }
        [JsonPropertyName("L2conn")]public string UseL2ConnectionParameters { get; set; } 
        //public double? MySqlProtocolVersion { get; set; }
        //public string MySqlServerVersion { get; set; }
        //public double? MySqlCharacterset { get; set; }
        //public double? MySqlServerCapabilities { get; set; }
        [JsonPropertyName("appflowlog")]public string AppFlowLogging { get; set; }
        public string NetProfile { get; set; }
        public string IcmpvsrResponse { get; set; } //todo
        [JsonPropertyName("rhistate")]public string RouteHostInjectionState { get; set; }
        //public string AuthnProfile { get; set; }
        //public string DnsProfileName { get; set; }
    }
}