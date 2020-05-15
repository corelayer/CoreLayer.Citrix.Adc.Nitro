using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.NS;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsVersion
{
    public class NsVersionGetResponse : NitroResponse
    {
        [JsonPropertyName("nsversion")]
        public NsVersionConfiguration NsVersion { get; set; }
    }
}