using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsHttpProfile
{
    public class NsHttpProfileUpdateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/nshttpprofile";
        public override INitroRequestOptions Options => new NsHttpProfileUpdateRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public NsHttpProfileUpdateRequestConfiguration(NsHttpProfileUpdateRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}