using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.System
{
    public class SystemUserSystemGroupBindingConfiguration
    {
        public string UserName { get; set; }
        public string GroupName { get; set; }
        [JsonPropertyName("__count")]public double Count { get; set; }
    }
}