using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsHttpProfile
{
    public class NsHttpProfileGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/nshttpprofile";
        public override INitroRequestDataRoot DataRoot => new NsHttpProfileGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new NsHttpProfileGetRequestOptions();
    }
}