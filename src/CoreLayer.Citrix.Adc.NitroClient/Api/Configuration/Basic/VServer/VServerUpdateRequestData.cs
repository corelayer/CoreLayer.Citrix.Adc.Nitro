using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Basic.VServer
{
    public class VServerUpdateRequestData
    {
        public string Name { get; set; }
        [JsonPropertyName("backupvserver")]public string BackupVirtualServer { get; set; }
        public string RedirectUrl { get; set; }
        public string Cacheable { get; set; }
        [JsonPropertyName("clttimeout")]public string ClientTimeout { get; set; }
        [JsonPropertyName("somethod")]public string SpillOverMethod { get; set; }
        [JsonPropertyName("sopersistence")]public string SpillOverPersistence { get; set; }
        [JsonPropertyName("sopersistencetimeout")]public string SpillOverPersistenceTimeout { get; set; }
        [JsonPropertyName("sothreshold")]public string SpillOverThreshold { get; set; }
        [JsonPropertyName("pushvserver")]public string PushVirtualServer { get; set; }
    }
}