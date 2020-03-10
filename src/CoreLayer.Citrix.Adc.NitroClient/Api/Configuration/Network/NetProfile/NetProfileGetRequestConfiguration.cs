using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.NetProfile
{
    public class NetProfileGetRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Get;
        public override string ResourcePath => "/nitro/v1/config/netprofile";
        public override INitroRequestDataRoot DataRoot => new NetProfileGetRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new NetProfileGetRequestOptions();
    }
}