using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.Network;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.NetProfile
{
    public class NetProfileGetResponse : NitroResponse
    {
        [JsonPropertyName("netprofile")]
        public NetProfileConfiguration[] NetProfiles { get; set; }
    }
}