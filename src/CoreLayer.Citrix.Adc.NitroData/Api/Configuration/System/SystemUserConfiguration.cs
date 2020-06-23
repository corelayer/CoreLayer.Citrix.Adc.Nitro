using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.System
{
    public class SystemUserConfiguration
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Encrypted { get; set; }
        public string HashMethod { get; set; }
        [JsonPropertyName("externalauth")]public string ExternalAuthentication { get; set; }
        public string PromptString { get; set; }
        public string PromptInheritedFrom { get; set; }
        public double Timeout { get; set; }
        public string TimeoutKind { get; set; }
        public string Logging { get; set; }
        public string MaxSession { get; set; }
        public string[] AllowedManagementInterface { get; set; }
        public string AllowedManagementInterfaceKind { get; set; }
    }
}