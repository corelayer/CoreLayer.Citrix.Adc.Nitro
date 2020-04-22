using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Ssl;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertLink
{
    public class SslCertLinkGetResponse
    {
        [JsonPropertyName("sslcertlink")]public SslCertLinkConfiguration[] SslCertLinks { get; set; }
    }
}