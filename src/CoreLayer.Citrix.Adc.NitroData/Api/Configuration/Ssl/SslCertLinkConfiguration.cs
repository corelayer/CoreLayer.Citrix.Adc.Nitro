using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Ssl
{
    public class SslCertLinkConfiguration
    {
        public string CertKeyName { get; set; }
        public string LinkCertKeyName { get; set; }
        [JsonPropertyName("__count")]public int Count { get; set; }
    }
}