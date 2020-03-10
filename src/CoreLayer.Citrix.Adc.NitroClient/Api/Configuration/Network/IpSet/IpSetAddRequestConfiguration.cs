using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.IpSet
{
    public class IpSetAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/ipset";
        public override INitroRequestOptions Options => new IpSetAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public IpSetAddRequestConfiguration(IpSetAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}