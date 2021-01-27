using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.SSL.SslCertFile
{
    public class SslCertFileImportRequestData : INitroRequestData
    {
        public string Name { get; set; }
        
        [JsonPropertyName("src")]
        public string Source { get; set; }
    }
}