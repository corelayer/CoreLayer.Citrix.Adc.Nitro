﻿﻿using System.Text.Json.Serialization;

  namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServerConfiguration //: IServerConfiguration
    {
        public string Name { get; set; }
        [JsonPropertyName("svctype")]public string ServiceType { get; set; }
        [JsonPropertyName("dup_svctype")]public string DuplicateServiceType { get; set; }
        public int? Port { get; set; }
        [JsonPropertyName("dup_port")]public int? DuplicatePort { get; set; }
        [JsonPropertyName("svrstate")]public string ServerState { get; set; }
        public bool? Internal { get; set; }
        public string IpAddress { get; set; }
        public string State { get; set; }
        public string Domain { get; set; }
        public bool? DomainResolveNow { get; set; }
        public int? DomainResolveRetry { get; set; }
        public string TranslationIp { get; set; }
        public string TranslationMask { get; set; }
        public string Comment { get; set; }
        public double? Delay { get; set; }
        public string Graceful { get; set; }
        public string StateChangeTimeSec { get; set; }
        public string TicksSinceLastStateChange { get; set; }
        [JsonPropertyName("ipv6address")]public string SupportIpV6Address { get; set; }
        [JsonPropertyName("td")]public string TrafficDomain { get; set; }
        public string AutoScale { get; set; }
        [JsonPropertyName("usip")]public string UseSourceIp { get; set; }
        [JsonPropertyName("cka")]public string ClientKeepAlive { get; set; }
        [JsonPropertyName("tcpb")]public string TcpBuffering { get; set; }
        [JsonPropertyName("cmp")]public string Compression { get; set; }
        public string Cacheable { get; set; }
        [JsonPropertyName("sc")]public string SureConnect { get; set; }
        [JsonPropertyName("sp")]public string SurgeProtection { get; set; }
        [JsonPropertyName("svrcfgflags")]public string ServerCfgFlags { get; set; }  //todo
        [JsonPropertyName("maxreq")]public string MaxRequest { get; set; } 
        public string MaxBandWidth { get; set; }
        [JsonPropertyName("svcitmactsvcs")]public string ServiceItemActiveServices { get; set; } 
        [JsonPropertyName("svcitmboundsvcs")]public string ServiceItemBoundServices { get; set; } 
        public string Weight { get; set; }
        public string QueryType { get; set; }
        [JsonPropertyName("__count")]public double? Count { get; set; }
    }
}