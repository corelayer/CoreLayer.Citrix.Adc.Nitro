﻿﻿using System.Text.Json.Serialization;

  namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServerConfiguration : IServerConfiguration
    {
        public string Name { get; set; }
        public string SvcType { get; set; }
        public string Dup_SvcType { get; set; }
        public int? Port { get; set; }
        public int? Dup_Port { get; set; }
        public string SvrState { get; set; }
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
        public string Td { get; set; }
        public string AutoScale { get; set; }
        public string Usip { get; set; }
        public string Cka { get; set; }
        public string TcpB { get; set; }
        public string Cmp { get; set; }
        public string Cacheable { get; set; }
        public string Sc { get; set; }
        public string Sp { get; set; }
        public string SvrCfgFlags { get; set; }
        public string MaxReq { get; set; }
        public string MaxBandWidth { get; set; }
        public string Svcitmactsvcs { get; set; }
        public string Svcitmboundsvcs { get; set; }
        public string Weight { get; set; }
        public string QueryType { get; set; }
        [JsonPropertyName("__count")]public double? Count { get; set; }
    }
}