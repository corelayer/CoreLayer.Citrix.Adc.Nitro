using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Ssl;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslProfile
{
    public class SslProfileGetResponse
    {
        [JsonPropertyName("sslprofile")]
        public SslProfileConfiguration[] SslProfiles { get; set; }
    }
}