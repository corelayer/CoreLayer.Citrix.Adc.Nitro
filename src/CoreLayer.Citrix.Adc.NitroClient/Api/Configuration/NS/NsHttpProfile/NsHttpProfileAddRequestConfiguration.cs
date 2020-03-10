using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsHttpProfile
{
    public class NsHttpProfileAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/nshttpprofile";
        public override INitroRequestOptions Options => new NsHttpProfileAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public NsHttpProfileAddRequestConfiguration(NsHttpProfileAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}