using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsTcpProfile
{
    public class NsTcpProfileGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/nstcpprofile";
        public override INitroRequestDataRoot DataRoot => new NsTcpProfileGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new NsTcpProfileGetRequestOptions();
    }
}