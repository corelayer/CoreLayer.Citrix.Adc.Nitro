using System.Text.Json.Serialization;
using CoreLayer.Citrix.Adc.NitroData.Api.Configuration.NS;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsHttpProfile
{
    public class NsHttpProfileGetResponse : NitroResponse
    {
        [JsonPropertyName("nshttpprofile")]
        public NsHttpProfileConfiguration[] NsHttpProfiles { get; set; }
    }
}