using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsTcpProfile
{
    public class NsTcpProfileUpdateRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Put;
        public override string ResourcePath => "/nitro/v1/config/nstcpprofile";
        public override INitroRequestOptions Options => new NsTcpProfileUpdateRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public NsTcpProfileUpdateRequestConfiguration(NsTcpProfileUpdateRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}