using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ssl;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ssl.Ssl
{
    public class SslStatResponse : NitroResponse
    {
        [JsonPropertyName("ssl")]
        public SslStats[] SslStatistics { get; set; }
    }
}