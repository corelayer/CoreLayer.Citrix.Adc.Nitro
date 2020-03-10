using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsTcpProfile
{
    public class NsTcpProfileAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/nstcpprofile";
        public override INitroRequestOptions Options => new NsTcpProfileAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public NsTcpProfileAddRequestConfiguration(NsTcpProfileAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}