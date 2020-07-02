using System.Text.Json.Serialization;

namespace CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Ssl
{
    public class SslCertLinkConfiguration
    {
        [JsonPropertyName("certkeyname")]public string CertificateKeyName { get; set; }
        [JsonPropertyName("linkcertkeyname")]public string LinkCertificateKeyName { get; set; }
        [JsonPropertyName("__count")]public int Count { get; set; }
    }
}