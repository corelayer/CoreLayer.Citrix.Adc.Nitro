using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.System
{
    public class SystemUserSystemCmdPolicyBindingConfiguration
    {
        public string Priority { get; set; }
        public string UserName { get; set; }
        public string PolicyName { get; set; }
        [JsonPropertyName("__count")]public double Count { get; set; }
    }
}