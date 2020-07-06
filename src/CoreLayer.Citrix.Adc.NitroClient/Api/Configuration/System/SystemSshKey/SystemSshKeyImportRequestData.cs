using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.System.SystemSshKey
{
    public class SystemSshKeyImportRequestData
    {
        public string Name { get; set; }
        [JsonPropertyName("src")]public string Source { get; set; }
        public string SshKeyType { get; set; }
    }
}