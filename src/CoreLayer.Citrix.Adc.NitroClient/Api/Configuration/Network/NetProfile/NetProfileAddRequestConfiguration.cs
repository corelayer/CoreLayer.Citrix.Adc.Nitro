using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.NetProfile
{
    public class NetProfileAddRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Post;
        public override string ResourcePath => "/nitro/v1/config/netprofile";
        public override INitroRequestOptions Options => new NetProfileAddRequestOptions();
        public override INitroRequestDataRoot DataRoot { get; }

        public NetProfileAddRequestConfiguration(NetProfileAddRequestDataRoot dataRoot)
        {
            DataRoot = dataRoot;
        }
    }
}