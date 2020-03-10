using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.NS.NsTcpProfile
{
    public class NsTcpProfileRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/nstcpprofile";
        public override INitroRequestDataRoot DataRoot => new NsTcpProfileRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new NsTcpProfileRemoveRequestOptions();
    }
}