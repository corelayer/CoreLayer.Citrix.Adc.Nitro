using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Ssl
{
    public class SslCertFileConfiguration
    {
        public string Name { get; set; }
        [JsonPropertyName("src")]public string Source { get; set; }
    }
}