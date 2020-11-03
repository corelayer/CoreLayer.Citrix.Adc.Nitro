using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Basic
{
    public class ServicegroupBindingServicegroupMemberConfiguration
    {
        //todo check  documented types == actual returned types
        public string ServicegroupName { get; set; }
        public string Ip { get; set; }
        public int? Port { get; set; }
        public string NameServer { get; set; }
        public string State { get; set; }
        public string HashId { get; set; }
        public string ServerId { get; set; }
        public string ServerName { get; set; }
        public string CustomServerId { get; set; }
        public string Weight { get; set; }
        [JsonPropertyName("dbsttl")]public double? DomainBasedServiceTtl { get; set; }
        [JsonPropertyName("svcitmpriority")]public double? ServiceItemPriority { get; set; }
        public double? Delay { get; set; }
        public string StateChangeTimeSec { get; set; }
        [JsonPropertyName("svrstate")]public string ServerState { get; set; }
        public string TicksSinceLastStateChange { get; set; }
        public string TrofsReason { get; set; }
        public string Graceful { get; set; }
    }
}