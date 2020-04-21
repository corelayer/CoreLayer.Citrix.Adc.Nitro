using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Ssl;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertFile
{
    public class SslCertFileGetResponse
    {
        [JsonPropertyName("sslcertfile")]
        public SslCertFileConfiguration[] SslCertFiles { get; set; }
    }
}