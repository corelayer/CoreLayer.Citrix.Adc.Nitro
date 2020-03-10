using System.Net.Http;
using CoreLayer.Citrix.Adc.NitroClient.Interfaces;

namespace CoreLayer.Citrix.Adc.NitroClient.Api.Configuration.Network.IpSet
{
    public class IpSetRemoveRequestConfiguration : NitroRequestConfiguration
    {
        public override HttpMethod Method => HttpMethod.Delete;
        public override string ResourcePath => "/nitro/v1/config/ipset";
        public override INitroRequestDataRoot DataRoot => new IpSetRemoveRequestDataRoot();
        public override INitroRequestOptions Options { get; set; } = new IpSetRemoveRequestOptions();
    }
}