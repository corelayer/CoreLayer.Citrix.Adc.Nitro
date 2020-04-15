using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.NS;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsTcpProfile
{
    public class NsTcpProfileGetResponse
    {
        [JsonPropertyName("nstcpprofile")]
        public NsTcpProfileConfiguration[] NsTcpProfiles { get; set; }
    }
}