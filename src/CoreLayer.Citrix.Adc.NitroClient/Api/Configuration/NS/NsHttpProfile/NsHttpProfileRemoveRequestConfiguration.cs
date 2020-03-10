using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsHttpProfile
{
    public class NsHttpProfileRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/nshttpprofile";
        public override INitroRequestDataRoot DataRoot => new NsHttpProfileRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new NsHttpProfileRemoveRequestOptions();
    }
}