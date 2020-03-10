using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.NetProfile
{
    public class NetProfileRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/netprofile";
        public override INitroRequestDataRoot DataRoot => new NetProfileRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new NetProfileRemoveRequestOptions();
    }
}