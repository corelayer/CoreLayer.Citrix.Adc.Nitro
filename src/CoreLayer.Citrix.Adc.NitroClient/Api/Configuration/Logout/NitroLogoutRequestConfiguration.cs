using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Logout
{
    public class NitroLogoutRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/logout";
        public override INitroRequestOptions Options => new NitroLogoutRequestOptions();
        public override INitroRequestDataRoot DataRoot => new NitroLogoutRequestDataRoot();
    }
}