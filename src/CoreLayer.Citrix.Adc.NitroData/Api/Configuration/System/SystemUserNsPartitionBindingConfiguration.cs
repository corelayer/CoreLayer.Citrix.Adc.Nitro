using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.System
{
    public class SystemUserNsPartitionBindingConfigurationConfiguration
    {
        public string UserName { get; set; }
        public string PartitionName { get; set; }
        [JsonPropertyName("__count")] public double Count { get; set; }
    }
}