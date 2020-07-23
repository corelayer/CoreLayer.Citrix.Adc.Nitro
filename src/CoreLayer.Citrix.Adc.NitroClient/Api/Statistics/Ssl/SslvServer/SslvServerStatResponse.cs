using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Statistics.Ssl;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Statistics.Ssl.SslvServer
{
    public class SslvServerStatResponse : NitroResponse
    {
        [JsonPropertyName("sslvserver")]
        public SslvServerStats SslvServerStatistics { get; set; }
    }
}