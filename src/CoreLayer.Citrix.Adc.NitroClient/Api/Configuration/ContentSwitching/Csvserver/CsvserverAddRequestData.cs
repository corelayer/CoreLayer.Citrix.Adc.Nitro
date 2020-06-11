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
            Ipv46 = ip;
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
        public string Ipv46 { get; }
        public int? Port { get; }
        public string IpPattern { get; }
        public string IpMask { get; }
        
        public double? Td { get; set; }
        public string TargetType { get; set; }
        public string DnsRecordType { get; set; }
        public double? PersistenceId { get; set; }
        public double? Range { get; set; }
        public string State { get; set; }
        public string StateUpdate { get; set; }
        //public string Cacheable { get; set; } 
        //public string RedirectUrl { get; set; } 
        public double? CltTimeout { get; set; }
        public string Precedence { get; set; }
        public string CaseSensitive { get; set; }
        public string SoMethod { get; set; } 
        public string SoPersistence { get; set; } 
        public double? SoPersistenceTimeout { get; set; }
        public double? SoThreshold { get; set; } 
        public string SoBackupAction { get; set; }
        //public string RedirectPortRewrite { get; set; }
        public string DownstateFlush { get; set; }
        public string BackupVserver { get; set; }
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
        public string L2Conn { get; set; } 
        //public double? MySqlProtocolVersion { get; set; }
        //public string MySqlServerVersion { get; set; }
        //public double? MySqlCharacterset { get; set; }
        //public double? MySqlServerCapabilities { get; set; }
        public string AppFlowLog { get; set; }
        public string NetProfile { get; set; }
        public string IcmpvsrResponse { get; set; } 
        public string RhiState { get; set; }
        //public string AuthnProfile { get; set; }
        //public string DnsProfileName { get; set; }
    }
}