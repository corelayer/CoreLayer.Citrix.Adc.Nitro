using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Login
{
    public class NitroLoginRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/login";
        public override INitroRequestOptions Options => new NitroLoginRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; } = new NitroLoginRequestDataRoot();

        public NitroLoginRequestConfiguration()
        {
            DataRoot = new NitroLoginRequestDataRoot();
        }

        public NitroLoginRequestConfiguration(NitroLoginRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}