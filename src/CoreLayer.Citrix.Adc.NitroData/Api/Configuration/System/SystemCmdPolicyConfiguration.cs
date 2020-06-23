using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.System
{
    public class SystemCmdPolicyConfiguration
    {
        public string PolicyName { get; set; }
        public string Action { get; set; }
        [JsonPropertyName("cmdspec")]public string CommandSpecification { get; set; }
        public string[] BuiltIn { get; set; }
        public string Feature { get; set; }
    }
}