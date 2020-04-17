﻿﻿using System.Text.Json.Serialization;

  namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServerConfiguration : IServerConfiguration
    {
        public string Name { get; set; }
        [JsonPropertyName("svctype")]public string ServiceType { get; set; }
        public string Dup_SvcType { get; set; }
        public int? Port { get; set; }
        public int? Dup_Port { get; set; }
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
        public string IpV6Address { get; set; }
        [JsonPropertyName("td")]public string TrafficDomain { get; set; }
        public string AutoScale { get; set; }
        [JsonPropertyName("usip")]public string UseSourceIp { get; set; }
        [JsonPropertyName("cka")]public string ClientKeepAlive { get; set; }
        [JsonPropertyName("tcpb")]public string TcpBuffering { get; set; }
        [JsonPropertyName("cmp")]public string Compression { get; set; }
        public string Cacheable { get; set; }
        [JsonPropertyName("sc")]public string SureConnect { get; set; }
        [JsonPropertyName("sp")]public string SurgeProtection { get; set; }
        [JsonPropertyName("svrcfgflags")]public string ServerCfgFlags { get; set; }
        public string MaxReq { get; set; }
        public string MaxBandWidth { get; set; }
        public string Svcitmactsvcs { get; set; }
        public string Svcitmboundsvcs { get; set; }
        public string Weight { get; set; }
        public string QueryType { get; set; }
        [JsonPropertyName("__count")]public double? Count { get; set; }
    }
}